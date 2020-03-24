import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'

@Component({
  selector: 'app-request-for-wages',
  templateUrl: './request-for-wages.component.html',
  styleUrls: ['./request-for-wages.component.scss']
})
export class RequestForWagesComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public wagesInitiateForm: FormGroup;
  public formSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  wagesFormInit() {
    this.wagesInitiateForm = this.fb.group({
      mailingDate             : ['', Validators.required],
      caseNumber              : ['', Validators.required],
      claimantName            : ['', Validators.required],
      claimantSSN             : ['', Validators.required],
      deadlineDate            : ['', Validators.required],
      preparerName            : ['', Validators.required],
      telephoneNumber         : ['', Validators.required],
      faxNumber               : ['', Validators.required],
    });
  }

  get fc() { return this.wagesInitiateForm.controls; }

  submitWagesInitiateForm() {
    this.formSubmitted = true;
    if (this.wagesInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this. wagesFormInit()
  }

}
