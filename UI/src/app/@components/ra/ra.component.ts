import { Component, OnInit, ViewChild, ChangeDetectorRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TabsetComponent } from 'ngx-bootstrap';
import { IDropdownSettings } from 'ng-multiselect-dropdown';

import { Base64 } from 'js-base64';

import { AppService } from 'app/@services/app.service'
import { RaApiService } from 'app/@services/ra-api.service'
import { ToastrService } from 'ngx-toastr';

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


  public uploadFiles: any;
  public filestring: string;

  // form setion var 
  public batchInitiateForm: FormGroup;
  public formSubmitted: boolean = false;

  constructor(
    public aps: AppService,
    private fb: FormBuilder,
    private router: Router,
    private ras: RaApiService,
    private datePipe: DatePipe,
    private tort: ToastrService,
    private cd: ChangeDetectorRef
  ) {

  }


  // form section 
  batchFormInit() {
    this.batchInitiateForm = this.fb.group({
      batchName: ['', Validators.required],
      batchDescription: ['', Validators.required],
      TemplateID: ['', Validators.required],
      isAnnual: ['', Validators.required],
      recipientSet: ['', Validators.required],
      scheduleDate: [null],
      base64Val: [null]
    });
  }

  batchFormConditionCheck() {
    const base64 = this.batchInitiateForm.get('base64Val');
    const recipientSet = this.batchInitiateForm.get('recipientSet')
    const scheduleDate = this.batchInitiateForm.get('scheduleDate')

    this.batchInitiateForm.get('isAnnual').valueChanges
      .subscribe(value => {
        if (value == 'custom') {
          base64.setValidators([Validators.required])
          recipientSet.clearValidators();
          scheduleDate.clearValidators();
        } else {
          recipientSet.setValidators(Validators.required)
          scheduleDate.setValidators(Validators.required)
          base64.clearValidators();
        }
        base64.updateValueAndValidity()
        recipientSet.updateValueAndValidity()
        scheduleDate.updateValueAndValidity()
      }
      );
  }

  get bfi() { return this.batchInitiateForm.controls; }

  submitBatchInitiateForm() {
    this.formSubmitted = true;
    if (this.batchInitiateForm.invalid) { return; }
  }

  gotoNotificationLogs(id) {
    this.router.navigateByUrl(`/ra/notification-log/${id}`);
  }


  createBatch() {

    let recipientValue = "";
    if (this.batchInitiateForm.value.recipientSet.length > 0) {
      for (let i = 0; i < this.batchInitiateForm.value.recipientSet.length; i++) {
        recipientValue += this.batchInitiateForm.value.recipientSet[i].item_id + ',';
      }
      recipientValue = recipientValue.replace(/,\s*$/, "")
    }

    let data;

    if (this.batchInitiateForm.value.isAnnual != 'custom') {
      data = {
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
    } else {
      data = {
        "id": 0,
        "batchName": this.batchInitiateForm.value.batchName,
        "batchDescription": this.batchInitiateForm.value.batchDescription,
        "TemplateID": this.batchInitiateForm.value.TemplateID,
        "isCustom": true,
        "uploadExcel": this.filestring,
        "filetype": "xlxs"
      }
    }

    console.log(this.batchInitiateForm.valid)

    if (!this.batchInitiateForm.invalid) {
      this.ras.createBatch(data)
        .subscribe(
          (res) => {
            this.aps.closeModel()
            this.tort.success('Created', 'Batch Created Successfully!', { timeOut: 5000, });
            this.getBatches()
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
          if(this.schedulesList.length > 0) {
            this.getBatchesDetails(this.schedulesList[0].id)
          }
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
          this.selectedItems = []
          for (let i = 0; i < Object.keys(resdata).length; i++) {
            this.dropdownList.push({ item_id: `${resdata[i].id}`, item_text: `${resdata[i].recipientRuleType}` });
          }
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
        },
        (error) => {
          console.log('error caught in template call', error)
        }
      )
  }

  showRecipientSection(val) {
    this.cd.markForCheck();
    this.showRecipient = true
    this.showUpbtn = false
    this.multiselectConfig(val)
  }

  showUpfileSection() {
    this.cd.markForCheck();
    this.showRecipient = false
    this.showUpbtn = true
  }

  convertToBase64(event) {
    this.uploadFiles = event.target.files;
    var reader = new FileReader();
    reader.onload = this._handleReaderLoaded.bind(this);
    reader.readAsBinaryString(this.uploadFiles[0]);
  }

  _handleReaderLoaded(readerEvt) {
    var binaryString = readerEvt.target.result;
    this.filestring = btoa(binaryString);
  }

  ngOnInit() {
    this.multiselectConfig('True')
    this.batchFormInit()
    this.batchFormConditionCheck()
    this.getTemplateId()
    this.getBatches()
    this.getBiweeklyBatches()
  }

}
