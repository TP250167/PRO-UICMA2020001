import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-appeal-form',
  templateUrl: './appeal-form.component.html',
  styleUrls: ['./appeal-form.component.scss']
})
export class AppealFormComponent implements OnInit {

  @Input() uavalue: any;

  // form setion var 
  AppealForm: FormGroup;
  formSubmitted: boolean = false;

  public formId: number;
  public appealFormDetails: any = []

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private route: ActivatedRoute,
  ) {

  }

  // form section 
  appealFormInit() {
    this.AppealForm = this.fb.group({
      id                           : ['', Validators.required],
      claimId                      : ['', Validators.required],
      claimantName                 : ['', Validators.required],
      socialSecurityNumber         : ['', Validators.required],
      needTranslator               : ['', Validators.required],
      translatorLanguage           : ['', Validators.required],
      appellantAddress             : ['', Validators.required],
      appellantTelephoneNo         : ['', Validators.required],
      appellantFaxNo               : ['', Validators.required],
      appellantCellNo              : ['', Validators.required],
      appellantEmail               : ['', Validators.required],
      authorizeToSendEmail         : ['', Validators.required],
      authorizeToSendText          : ['', Validators.required],
      employerAccountNumber        : ['', Validators.required],
      agentName                    : ['', Validators.required],
      agentAddress                 : ['', Validators.required],
      appellantStatementNoticeDate : ['', Validators.required],
      appellantStatementComments   : ['', Validators.required],
      signature                    : ['', Validators.required],
      formDate                     : ['', Validators.required],
    });
  }

  get fc() { return this.AppealForm.controls; }
  get fv() { return this.AppealForm.value; }
  get fvalid() { return this.AppealForm.valid; }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.needTranslator.setValue(data.needTranslator)
    this.fc.translatorLanguage.setValue(data.translatorLanguage)
    this.fc.appellantAddress.setValue(data.appellantAddress)
    this.fc.appellantTelephoneNo.setValue(data.appellantTelephoneNo)
    this.fc.appellantFaxNo.setValue(data.appellantFaxNo)
    this.fc.appellantCellNo.setValue(data.appellantCellNo)
    this.fc.appellantEmail.setValue(data.appellantEmail)
    this.fc.authorizeToSendEmail.setValue(data.authorizeToSendEmail)
    this.fc.authorizeToSendText.setValue(data.authorizeToSendText)
    this.fc.employerAccountNumber.setValue(data.employerAccountNumber)
    this.fc.agentName.setValue(data.agentName)
    this.fc.agentAddress.setValue(data.agentAddress)
    this.fc.appellantStatementNoticeDate.setValue(this.aps.formatDate(data.appellantStatementNoticeDate))
    this.fc.appellantStatementComments.setValue(data.appellantStatementComments)
    this.fc.signature.setValue(data.signature)
    this.fc.formDate.setValue(this.aps.formatDate(data.formDate))
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 1
    this.cas.getDeterminationAppeal(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.appealFormDetails = res;
          this.setFormvalues(this.appealFormDetails)
        }
      })
  }

  saveForm() {
    if (this.fvalid) {
      this.fv.appellantStatementNoticeDate = this.aps.formatDate(this.fv.appellantStatementNoticeDate)
      this.fv.formDate = this.aps.formatDate(this.fv.formDate)

      this.cas.updateDeterminationAppeal(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
  }

  submitAppealForm() {
    this.formSubmitted = true;
    if (this.AppealForm.invalid) { return; }
    console.log(this.AppealForm.value)
  }

  ngOnInit() {
    this.appealFormInit()
    this.getFormDetails()
  }

}
