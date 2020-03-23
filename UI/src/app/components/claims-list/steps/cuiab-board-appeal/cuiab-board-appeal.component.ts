import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService  } from '@services/claims.service'

@Component({
  selector: 'app-cuiab-board-appeal',
  templateUrl: './cuiab-board-appeal.component.html',
  styleUrls: ['./cuiab-board-appeal.component.scss']
})
export class CuiabBoardAppealComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public cuiabBoardAppealInitiateForm: FormGroup;
  public bifSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  CuiabBoardAppealFormInit() {
    this.cuiabBoardAppealInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      lausdFaxDate           : ['', Validators.required],
      lausdAcNo              : ['', Validators.required],
      ClaimDateByb           : ['', Validators.required],
      claimantName           : ['', Validators.required],
      claimantSSN            : ['', Validators.required],
      caseNo                 : ['', Validators.required],
      appealStatement        : ['', Validators.required],
      printName              : ['', Validators.required],
      phoneNo                : ['', Validators.required],
      signature              : ['', Validators.required],
      title                  : ['', Validators.required],
      date                   : ['', Validators.required],
      PartyFa                : ['', Validators.required],
      appellantName          : ['', Validators.required],
      appellantPn            : ['', Validators.required],
      appellantFn            : ['', Validators.required],
      appellantMa            : ['', Validators.required],
      aljDecisionDate        : ['', Validators.required],
      aljDcn                 : ['', Validators.required],
      giveCp                 : ['', Validators.required],
      emailAddress           : ['', Validators.required],
      cellPhoneNo            : ['', Validators.required],
      eClaimantName          : ['', Validators.required],
      eClaimantSSN           : ['', Validators.required],
      employerAn             : ['', Validators.required],
      appellantArn           : ['', Validators.required],
      appellantAra           : ['', Validators.required],
      appellantArs           : ['', Validators.required],
      dateSigned             : ['', Validators.required],
      disagreeReason         : ['', Validators.required],
     
    });
  }

  get bfi() { return this.cuiabBoardAppealInitiateForm.controls; }

  submitCUIABBoardAppealInitiateForm() {
    this.bifSubmitted = true;
    if (this.cuiabBoardAppealInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.CuiabBoardAppealFormInit()
  }

}
