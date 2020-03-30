import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-benefit-charge',
  templateUrl: './benefit-charge.component.html',
  styleUrls: ['./benefit-charge.component.scss']
})
export class BenefitChargeComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public bfcForm: FormGroup;
  public formSubmitted: boolean = false;

  public benefitChargeDetail: any = []
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
  benefitChargeFormInit() {
    this.bfcForm = this.fb.group({
      id         : [''                     ],
      claimId    : [''                     ],
      letterId   : ['', Validators.required],
      issuedDate : ['', Validators.required],
      accountId  : ['', Validators.required],
      claimantSSN: ['', Validators.required],
    });
  }

  get fc() { return this.bfcForm.controls; }
  get fv() { return this.bfcForm.value; }
  get fvalid() { return this.bfcForm.valid; }

  submitBfcForm() {
    this.formSubmitted = true;
    if (this.bfcForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.letterId.setValue(data.letterId)
    this.fc.issuedDate.setValue(this.aps.formatDate(data.issuedDate))
    this.fc.accountId.setValue(data.accountId)
    this.fc.claimantSSN.setValue(data.claimantSSN)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id'))
    this.formId = 1
    this.cas.getBenefitCharge(this.formId)
      .subscribe((res) => {
        this.benefitChargeDetail = res;
        this.setFormvalues(this.benefitChargeDetail)
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.issuedDate = this.aps.formatDate(this.fv.issuedDate)

      this.cas.updateBenefitCharge(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.benefitChargeFormInit()
    this.getFormDetails()
  }

}
