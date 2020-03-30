import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-cuiab-board-appeal',
  templateUrl: './cuiab-board-appeal.component.html',
  styleUrls: ['./cuiab-board-appeal.component.scss']
})
export class CuiabBoardAppealComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public cuiabaFrom: FormGroup;
  public formSubmitted: boolean = false;

  public formId: number;
  public cuiabaFromDetails: any = [];

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
  CuiabBoardAppealFormInit() {
    this.cuiabaFrom = this.fb.group({
      id                         : ['', Validators.required],
      claimId                    : ['', Validators.required],
      cuiabAddress               : ['', Validators.required],
      lausdFaxDate               : ['', Validators.required],
      lausdAccountNumber         : ['', Validators.required],
      bybClaimDate               : ['', Validators.required],
      claimantName               : ['', Validators.required],
      socialSecurityNumber       : ['', Validators.required],
      caseNumber                 : ['', Validators.required],
      appealStatement            : ['', Validators.required],
      userPrintName              : ['', Validators.required],
      userPhoneNumber            : ['', Validators.required],
      userSignature              : ['', Validators.required],
      userTitle                  : ['', Validators.required],
      userDate                   : ['', Validators.required],
      partyFilingAppeal          : ['', Validators.required],
      appellantName              : ['', Validators.required],
      appellantPhoneNumber       : ['', Validators.required],
      appellantFaxNumber         : ['', Validators.required],
      appellantMailAddress       : ['', Validators.required],
      aljDecisionDate            : ['', Validators.required],
      aljDecisionCaseNumber      : ['', Validators.required],
      cuiabPermission            : ['', Validators.required],
      lausdEmailAddress          : ['', Validators.required],
      cellPhoneNumber            : ['', Validators.required],
      eClaimantName              : ['', Validators.required],
      eClaimantSSN               : ['', Validators.required],
      employerAccountNumber      : ['', Validators.required],
      appellantAgentRepName      : ['', Validators.required],
      appellantAgentRepAddress   : ['', Validators.required],
      appellantAgentRepSignature : ['', Validators.required],
      appellantAgentRepSignedDate: ['', Validators.required],
      disagreeReason             : ['', Validators.required],
    });
  }

  get fc() { return this.cuiabaFrom.controls; }
  get fv() { return this.cuiabaFrom.value; }
  get fvalid() { return this.cuiabaFrom.valid; }

  submitCuiabaFrom() {
    this.formSubmitted = true;
    if (this.cuiabaFrom.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.cuiabAddress.setValue(data.cuiabAddress)
    this.fc.lausdFaxDate.setValue(this.aps.formatDate(data.lausdFaxDate))
    this.fc.lausdAccountNumber.setValue(data.lausdAccountNumber)
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.caseNumber.setValue(data.caseNumber)
    this.fc.appealStatement.setValue(data.appealStatement)
    this.fc.userPrintName.setValue(data.userPrintName)
    this.fc.userPhoneNumber.setValue(data.userPhoneNumber)
    this.fc.userSignature.setValue(data.userSignature)
    this.fc.userTitle.setValue(data.userTitle)
    this.fc.userDate.setValue(this.aps.formatDate(data.userDate))
    this.fc.partyFilingAppeal.setValue(this.aps.formatDate(data.partyFilingAppeal))
    this.fc.appellantName.setValue(data.appellantName)
    this.fc.appellantPhoneNumber.setValue(data.appellantPhoneNumber)
    this.fc.appellantFaxNumber.setValue(data.appellantFaxNumber)
    this.fc.appellantMailAddress.setValue(data.appellantMailAddress)
    this.fc.aljDecisionDate.setValue(data.aljDecisionDate)
    this.fc.aljDecisionCaseNumber.setValue(data.aljDecisionCaseNumber)
    this.fc.cuiabPermission.setValue(data.cuiabPermission)
    this.fc.lausdEmailAddress.setValue(data.lausdEmailAddress)
    this.fc.cellPhoneNumber.setValue(data.cellPhoneNumber)
    this.fc.employerAccountNumber.setValue(data.employerAccountNumber)
    this.fc.appellantAgentRepName.setValue(data.appellantAgentRepName)
    this.fc.appellantAgentRepAddress.setValue(data.appellantAgentRepAddress)
    this.fc.appellantAgentRepSignature.setValue(data.appellantAgentRepSignature)
    this.fc.appellantAgentRepSignedDate.setValue(data.appellantAgentRepSignedDate)
    this.fc.disagreeReason.setValue(data.disagreeReason)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) ;
    this.formId = 1;
    this.cas.getCUIABBoardAppeal(this.formId)
      .subscribe((res) => {
        this.cuiabaFromDetails = res;
        this.setFormvalues(this.cuiabaFromDetails);
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.lausdFaxDate = this.aps.formatDate(this.fv.lausdFaxDate);
      this.fv.bybClaimDate = this.aps.formatDate(this.fv.bybClaimDate);
      this.fv.userDate     = this.aps.formatDate(this.fv.userDate);
      this.fv.partyFilingAppeal = this.aps.formatDate(this.fv.partyFilingAppeal)

      this.cas.updateCUIABBoardAppeal(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
    
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.CuiabBoardAppealFormInit()
    this.getFormDetails()
  }

}
