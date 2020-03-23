import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService  } from '@services/claims.service'

@Component({
  selector: 'app-de1101-interview',
  templateUrl: './de1101-interview.component.html',
  styleUrls: ['./de1101-interview.component.scss']
})
export class De1101InterviewComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  public de1101InterviewInitiateForm: FormGroup;
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
  de1101InterviewFormInit() {
    this.de1101InterviewInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      lausdFaxDate           : ['', Validators.required],
      ClaimDateByb           : ['', Validators.required],
      effectiveDate          : ['', Validators.required],
      claimantName           : ['', Validators.required],
      claimantSSN            : ['', Validators.required],
      issuesList             : ['', Validators.required],
      status                 : ['', Validators.required],
      question1              : ['', Validators.required],
      lausdResponse1         : ['', Validators.required],
      question2              : ['', Validators.required],
      lausdResponse2         : ['', Validators.required],
      question3              : ['', Validators.required],
      lausdResponse3         : ['', Validators.required],
      time                   : ['', Validators.required],
      detInterviewer         : ['', Validators.required],
      detiPhoneNo            : ['', Validators.required],
      printName              : ['', Validators.required],
      phoneNo                : ['', Validators.required],
      signature              : ['', Validators.required],
      title                  : ['', Validators.required],
      date                   : ['', Validators.required],
    });
  }

  get bfi() { return this.de1101InterviewInitiateForm.controls; }

  submitde1101InterviewInitiateForm() {
    this.bifSubmitted = true;
    if (this.de1101InterviewInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de1101InterviewFormInit()
  }

}
