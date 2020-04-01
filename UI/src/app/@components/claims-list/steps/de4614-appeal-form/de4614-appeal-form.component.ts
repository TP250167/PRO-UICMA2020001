import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-de4614-appeal-form',
  templateUrl: './de4614-appeal-form.component.html',
  styleUrls: ['./de4614-appeal-form.component.scss']
})
export class De4614AppealFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public De4614AppealForm: FormGroup;
  public formSubmitted: boolean = false;
  
  public appealFormDetails: any = []
  public formId: number;


  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) {

  }


  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  de4614AppealFormInit() {
    this.De4614AppealForm = this.fb.group({
      id                         : ['', Validators.required],
      claimId                    : ['', Validators.required],
      address                    : ['', Validators.required],
      lausdFaxDate               : ['', Validators.required],
      lausdAccountNumber         : ['', Validators.required],
      bybClaimDate               : ['', Validators.required],
      formDate                   : ['', Validators.required],
      claimantName               : ['', Validators.required],
      socialSecurityNumber       : ['', Validators.required],
      lausdEligibilityInformation: ['', Validators.required],
      printName                  : ['', Validators.required],
      phoneNumber                : ['', Validators.required],
      signature                  : ['', Validators.required],
      title                      : ['', Validators.required],
      date                       : ['', Validators.required],
    });
  }

  get fc() { return this.De4614AppealForm.controls; }
  get fv() { return this.De4614AppealForm.value; }
  get fvalid() { return this.De4614AppealForm.valid; }

  submitDe4614AppealForm() {
    this.formSubmitted = true;
    if (this.De4614AppealForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.address.setValue(data.address)
    this.fc.lausdFaxDate.setValue(this.aps.formatDate(data.lausdFaxDate))
    this.fc.lausdAccountNumber.setValue(data.lausdAccountNumber)
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
    this.fc.formDate.setValue(this.aps.formatDate(data.formDate))
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.lausdEligibilityInformation.setValue(data.lausdEligibilityInformation)
    this.fc.printName.setValue(data.printName)
    this.fc.phoneNumber.setValue(data.phoneNumber)
    this.fc.signature.setValue(data.signature)
    this.fc.title.setValue(data.title)
    this.fc.date.setValue(this.aps.formatDate(data.date))
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 4
    this.cas.getClaimAppeal(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.appealFormDetails = res;
          this.setFormvalues(this.appealFormDetails)
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.lausdFaxDate = this.aps.formatDate(this.fv.lausdFaxDate)
      this.fv.bybClaimDate = this.aps.formatDate(this.fv.bybClaimDate)
      this.fv.formDate = this.aps.formatDate(this.fv.formDate)
      this.fv.date = this.aps.formatDate(this.fv.date)

      this.cas.updateClaimAppeal(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de4614AppealFormInit()
    this.getFormDetails()
  }


}
