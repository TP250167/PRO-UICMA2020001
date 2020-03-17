import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TabsetComponent } from 'ngx-bootstrap';
import { IDropdownSettings } from 'ng-multiselect-dropdown';

import { AppService } from '../../services/app.service'
import { RaApiService } from '../../services/ra-api.service'

import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-ra',
  templateUrl: './ra.component.html',
  styleUrls: ['./ra.component.scss']
})
export class RaComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  public templateList: any = [];
  public dropdownList: any = [];
  public selectedItems: any = [];
  public dropdownSettings: any = {};

  public biWeeklyBatched: any = [];

  public showRecipient: boolean;
  public showUpbtn: boolean;


  public schedulesList: any = [];
  public batchDetails: any = [];


  // form setion var 
  public batchInitiateForm: FormGroup;
  public bifSubmitted: boolean = false;

  constructor(
    public aps: AppService,
    private fb: FormBuilder,
    private router: Router,
    private ras: RaApiService,
    private datePipe: DatePipe
  ) {

  }


  // form section 
  batchFormInit() {
    this.batchInitiateForm = this.fb.group({
      batchName: ['', Validators.required],
      recipientSet: ['', Validators.required],
      batchDescription: ['', Validators.required],
      TemplateID: ['', Validators.required],
      scheduleDate: ['', Validators.required],
      isAnnual : ['', Validators.required]
    });
  }

  get bfi() { return this.batchInitiateForm.controls; }

  submitBatchInitiateForm() {
    this.bifSubmitted = true;
    if (this.batchInitiateForm.invalid) { return; }
  }


  gotoNotificationLogs(id) {
    this.router.navigateByUrl(`/ra/notification-log/${id}`);
  }


  createBatch() {

    let recipientValue = "";

    for (let i = 0; i < this.batchInitiateForm.value.recipientSet.length; i++) {
      recipientValue += this.batchInitiateForm.value.recipientSet[i].item_id + ',';
    }

    recipientValue = recipientValue.replace(/,\s*$/, "")

    let data = {
      "id": 0,
      "batchName": this.batchInitiateForm.value.batchName,
      "batchDescription": this.batchInitiateForm.value.batchDescription,
      "isAnnual": this.batchInitiateForm.value.isAnnual,
      "TemplateID": this.batchInitiateForm.value.TemplateID,
      "RAbatchRecRule": {
        "RecipientRuleListId": recipientValue
      },
      "RASchedule": {
        "scheduleDate": this.datePipe.transform(this.batchInitiateForm.value.scheduleDate, 'MM-dd-yyyy'),
        "status": "Active"
      }
    }

    if (!this.batchInitiateForm.invalid) {
      this.ras.createBatch(data)
        .subscribe(
          (res) => {
            console.log(res)
          },
          (error) => {
            console.log('error caught in batch creation', error)
          }
        )
    } else {
      console.log("please fill the form first")
    }

  }

  getBatches() {
    this.ras.getAllBatch()
      .subscribe(
        (res) => {
          this.schedulesList = res;
          this.getBatchesDetails(this.schedulesList[0].id)
          console.log(this.schedulesList)
        },
        (error) => {
          console.log('error caught in get batch list', error)
        }
      )
  }

  getBatchesDetails(id) {
    this.ras.getBatchDetails(id)
      .subscribe(
        (res) => {
          this.batchDetails = res;
          console.log(this.batchDetails)
        },
        (error) => {
          console.log('error caught in get batch details', error)
        }
      )
  }

  multiselectConfig(bval) {

    this.ras.getRecipient(bval)
      .subscribe(
        (res) => {
          let resdata = res;
          this.dropdownList = []

          for (let i = 0; i < Object.keys(resdata).length; i++) {
            this.dropdownList.push({ item_id: `${resdata[i].id}`, item_text: `${resdata[i].recipientRuleType}` });
          }

          console.log(this.dropdownList)
        },
        (error) => {
          console.log('error caught in get batch details', error)
        }
      )

    this.dropdownSettings = {
      singleSelection: false,
      idField: 'item_id',
      textField: 'item_text',
      selectAllText: 'Select All',
      unSelectAllText: 'UnSelect All',
      itemsShowLimit: 3,
      allowSearchFilter: true
    };

  }

  getTemplateId() {
    this.ras.getTemplateId()
      .subscribe(
        (res) => {
          this.templateList = res;
          console.log(this.templateList)
        },
        (error) => {
          console.log('error caught in template call', error)
        }
      )
  }

  getBiweeklyBatches() {
    this.ras.getRaWeeklyBatch()
      .subscribe(
        (res) => {
          this.biWeeklyBatched = res;
          console.log(this.biWeeklyBatched)
        },
        (error) => {
          console.log('error caught in template call', error)
        }
      )
  }

  showRecipientSection(val) {
    console.log(val)
    this.showRecipient = true
    this.showUpbtn = false
    this.multiselectConfig(val)
  }

  showUpfileSection() {
    this.showRecipient = false
    this.showUpbtn = true
  }

  ngOnInit() {
    this.multiselectConfig('True')
    this.batchFormInit()
    this.getTemplateId()
    this.getBatches()
    this.getBiweeklyBatches()
  }

}
