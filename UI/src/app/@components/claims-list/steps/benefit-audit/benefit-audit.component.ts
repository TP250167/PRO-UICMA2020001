import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-benefit-audit',
  templateUrl: './benefit-audit.component.html',
  styleUrls: ['./benefit-audit.component.scss']
})
export class BenefitAuditComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public baForm: FormGroup;
  public formSubmitted: boolean = false;
  
  public benefitAuditDetail: any = []
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
  benefitAuditFormInit() {
    this.baForm = this.fb.group({
      id                   : [''                     ],
      claimId              : [''                     ],
      claimantName         : ['', Validators.required],
      socialSecurityNumber : ['', Validators.required],
      mailDate             : ['', Validators.required],
    });
  }

  get fc() { return this.baForm.controls; }
  get fv() { return this.baForm.value; }
  get fvalid() { return this.baForm.valid; }

  submitbaForm() {
    this.formSubmitted = true;
    if (this.baForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.mailDate.setValue(this.aps.formatDate(data.mailDate))

  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id'))
    this.formId = 1
    this.cas.getBenefitAudit(this.formId)
      .subscribe((res) => {
        this.benefitAuditDetail = res;
        this.setFormvalues(this.benefitAuditDetail)
      })
  }


  saveForm() {

    if (this.fvalid) {

      this.fv.mailDate = this.aps.formatDate(this.fv.mailDate)

      this.cas.updateBenefitAudit(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.benefitAuditFormInit()
    this.getFormDetails()
  }

}
