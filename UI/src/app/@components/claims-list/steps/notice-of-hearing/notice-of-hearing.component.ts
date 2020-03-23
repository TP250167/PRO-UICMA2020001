import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'

@Component({
  selector: 'app-notice-of-hearing',
  templateUrl: './notice-of-hearing.component.html',
  styleUrls: ['./notice-of-hearing.component.scss']
})
export class NoticeOfHearingComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public hearingInitiateForm: FormGroup;
  public hifSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  hearingFormInit() {
    this.hearingInitiateForm = this.fb.group({
      caseNo               : ['', Validators.required],
      claimantName         : ['', Validators.required],
      employerInfo         : ['', Validators.required],
      hearingDate          : ['', Validators.required],
      hearingTime          : ['', Validators.required],
      hearingPlace         : ['', Validators.required],
      issueCode            : ['', Validators.required],
      issueContext         : ['', Validators.required],
      appellantName        : ['', Validators.required],
      claimantAppellant    : ['', Validators.required],
      lausdAppelant        : ['', Validators.required],
      
    });
  }

  get hfi() { return this.hearingInitiateForm.controls; }

  submitHearingInitiateForm() {
    this.hifSubmitted = true;
    if (this.hearingInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.hearingFormInit()
  }


}
