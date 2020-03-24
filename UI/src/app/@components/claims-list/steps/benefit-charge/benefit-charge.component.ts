import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'

@Component({
  selector: 'app-benefit-charge',
  templateUrl: './benefit-charge.component.html',
  styleUrls: ['./benefit-charge.component.scss']
})
export class BenefitChargeComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public benefitchargeInitiateForm: FormGroup;
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
  benefitChargeFormInit() {
    this.benefitchargeInitiateForm = this.fb.group({
      letterID           : ['', Validators.required],
      issuedDate         : ['', Validators.required],
      accountID          : ['', Validators.required],
      claimantSSN        : ['', Validators.required],
    }); 
  }

  get fc() { return this.benefitchargeInitiateForm.controls; }

  submitBenefitAuditInitiateForm() {
    this.formSubmitted = true;
    if (this.benefitchargeInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.benefitChargeFormInit()
  }

}
