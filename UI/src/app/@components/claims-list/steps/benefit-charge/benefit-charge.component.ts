import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-benefit-charge',
  templateUrl: './benefit-charge.component.html',
  styleUrls: ['./benefit-charge.component.scss']
})
export class BenefitChargeComponent implements OnInit {

  @Input() uavalue: any;

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


  // form section 
  benefitChargeFormInit() {
    this.bfcForm = this.fb.group({
      id                   : ['', Validators.required],
      claimId              : ['', Validators.required],
      letterId             : ['', Validators.required],
      issuedDate           : ['', Validators.required],
      accountId            : ['', Validators.required],
      socialSecurityNumber : ['', Validators.required],
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
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id'))
    this.formId = 1
    this.cas.getBenefitCharge(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.benefitChargeDetail = res;
          this.setFormvalues(this.benefitChargeDetail)
        }
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
    this.benefitChargeFormInit()
    this.getFormDetails()
  }

}
