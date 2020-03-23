import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService  } from '@services/claims.service'

@Component({
  selector: 'app-benefit-audit',
  templateUrl: './benefit-audit.component.html',
  styleUrls: ['./benefit-audit.component.scss']
})
export class BenefitAuditComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public benefitAuditInitiateForm: FormGroup;
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
  benefitAuditFormInit() {
    this.benefitAuditInitiateForm = this.fb.group({
      claimName        : ['', Validators.required],
      claimantSSN      : ['', Validators.required],
      mailDate         : ['', Validators.required],
    });
  }

  get bfi() { return this.benefitAuditInitiateForm.controls; }

  submitBenefitAuditInitiateForm() {
    this.bifSubmitted = true;
    if (this.benefitAuditInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.benefitAuditFormInit()
  }

}