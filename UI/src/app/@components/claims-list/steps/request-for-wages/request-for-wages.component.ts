import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-request-for-wages',
  templateUrl: './request-for-wages.component.html',
  styleUrls: ['./request-for-wages.component.scss']
})
export class RequestForWagesComponent implements OnInit {

  @Input() uavalue: any;

  // form setion var 
  public rfwForm: FormGroup;
  public formSubmitted: boolean = false;

  public formId: number;
  public rfwFormDetails: any = [];

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) {

  }

  // form section 
  wagesFormInit() {
    this.rfwForm = this.fb.group({
      id                  : ['', Validators.required],
      claimId             : ['', Validators.required],
      mailingDate         : ['', Validators.required],
      caseNumber          : ['', Validators.required],
      claimantName        : ['', Validators.required],
      socialSecurityNumber: ['', Validators.required],
      deadLineDate        : ['', Validators.required],
      preparerName        : ['', Validators.required],
      telephoneNumber     : ['', Validators.required],
      faxNumber           : ['', Validators.required],
    });
  }

  get fc() { return this.rfwForm.controls; }
  get fv() { return this.rfwForm.value; }
  get fvalid() { return this.rfwForm.valid; }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.mailingDate.setValue(this.aps.formatDate(data.mailingDate))
    this.fc.caseNumber.setValue(data.caseNumber)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.deadLineDate.setValue(this.aps.formatDate(data.deadLineDate))
    this.fc.preparerName.setValue(data.preparerName)
    this.fc.telephoneNumber.setValue(data.telephoneNumber)
    this.fc.faxNumber.setValue(data.faxNumber)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) ;
    this.formId = 1;
    this.cas.getWagesAfterAppeal(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.rfwFormDetails = res;
          this.setFormvalues(this.rfwFormDetails);
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.mailingDate = this.aps.formatDate(this.fv.mailingDate);
      this.fv.deadLineDate = this.aps.formatDate(this.fv.deadLineDate);

      this.cas.updateWagesAfterAppeal(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
    
  }

  submitRfwForm() {
    this.formSubmitted = true;
    if (this.rfwForm.invalid) { return; }
  }

  ngOnInit() {
    this.wagesFormInit();
    this.getFormDetails();
  }

}
