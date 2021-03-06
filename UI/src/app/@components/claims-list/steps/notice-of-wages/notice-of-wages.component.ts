import { Component, OnInit, Input} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-notice-of-wages',
  templateUrl: './notice-of-wages.component.html',
  styleUrls: ['./notice-of-wages.component.scss']
})
export class NoticeOfWagesComponent implements OnInit {

  @Input() uavalue: any;

  // form setion var 
  public nofwForm: FormGroup;
  public formSubmitted: boolean = false;

  public formId: number ;
  public nofwFormDetails : any = []

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) {

  }

  // form section 
  NoticeOfWagesFormInit() {
    this.nofwForm = this.fb.group({
      id                              : ['', Validators.required],
      claimId                         : ['', Validators.required],
      claimantName                    : ['', Validators.required],
      socialSecurityNumber            : ['', Validators.required],
      totalWagesForEmployee           : ['', Validators.required],
      totalWagesForAllEmployees       : ['', Validators.required],
      benefitChargeableReserveAccount : ['', Validators.required],
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
      .subscribe((res) => {
        if(res != null) {
          this.nofwFormDetails = res;
          this.setFormvalues(this.nofwFormDetails);
        }
      })
  }

  saveForm() {

    if (this.fvalid) { 
      this.cas.updateWages(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.NoticeOfWagesFormInit();
    this.getFormDetails();
  }

}
