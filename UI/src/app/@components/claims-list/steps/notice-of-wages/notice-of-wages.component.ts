import { Component, OnInit,ElementRef,ViewChild,TemplateRef} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-notice-of-wages',
  templateUrl: './notice-of-wages.component.html',
  styleUrls: ['./notice-of-wages.component.scss']
})
export class NoticeOfWagesComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  nofwForm: FormGroup;
  formSubmitted: boolean = false;

  public formId: number ;
  public nofwFormDetails : any = []


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private tort: ToastrService,
    private route: ActivatedRoute,
  ) {

  }


  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  NoticeOfWagesFormInit() {
    this.nofwForm = this.fb.group({
      id                       : ['', Validators.required],
      claimId                  : ['', Validators.required],
      claimantName             : ['', Validators.required],
      socialSecurityNumber     : ['', Validators.required],
      totalWagesForEmployee    : ['', Validators.required],
      totalWagesForAllEmployees: ['', Validators.required],
      benefitChargeableReserveAccount           : ['', Validators.required],
    });
  }

  get fc() { return this.nofwForm.controls; }
  get fv() { return this.nofwForm.value; }
  get fvalid() { return this.nofwForm.valid; }

  submitNofwForm() {
    this.formSubmitted = true;
    if (this.nofwForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.totalWagesForEmployee.setValue(data.totalWagesForEmployee)
    this.fc.totalWagesForAllEmployees.setValue(data.totalWagesForAllEmployees)
    this.fc.benefitChargeableReserveAccount.setValue(data.benefitChargeableReserveAccount)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) ;
    this.formId = 1;
    this.cas.getWages(this.formId)
      .subscribe(
        (res) => {
          this.nofwFormDetails = res;
          this.setFormvalues(this.nofwFormDetails);
        },
        (error) => {
          console.log('error caught in get claim details', error);
        }
      )
  }

  saveForm() {
    if (this.fvalid) { 
      this.cas.updateWages(this.fv)
      .subscribe(
        (res) => {
          this.tort.success('claim', 'claim successfully updated', { timeOut: 5000, });
          console.log(res)
        },
        (error) => {
          console.log('error caught in batch detail update', error);
        }
      )
    }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.NoticeOfWagesFormInit();
    this.getFormDetails();
  }

}
