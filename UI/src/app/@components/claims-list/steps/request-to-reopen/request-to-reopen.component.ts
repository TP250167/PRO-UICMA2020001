import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService  } from '@services/claims.service'

@Component({
  selector: 'app-request-to-reopen',
  templateUrl: './request-to-reopen.component.html',
  styleUrls: ['./request-to-reopen.component.scss']
})
export class RequestToReopenComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public reopenInitiateForm: FormGroup;
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
  reopenFormInit() {
    this.reopenInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      mailDate               : ['', Validators.required],
      toALJ                  : ['', Validators.required],
      caseNo                 : ['', Validators.required],
      hdt                    : ['', Validators.required],
      claimantName           : ['', Validators.required],
      employer               : ['', Validators.required],
      accountNo              : ['', Validators.required],
      requestReason          : ['', Validators.required],
      signature              : ['', Validators.required],
    });
  }

  get bfi() { return this.reopenInitiateForm.controls; }

  submitReopenInitiateForm() {
    this.bifSubmitted = true;
    if (this.reopenInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.reopenFormInit()
  }


}
