import { Component, OnInit, ElementRef, ViewChild, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-response-to-employer',
  templateUrl: './response-to-employer.component.html',
  styleUrls: ['./response-to-employer.component.scss']
})
export class ResponseToEmployerComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  
  // form setion var 
  public De4614Form: FormGroup;
  public formSubmitted: boolean = false;

  public rteDetails: any = []
  public claimId: number;


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private route: ActivatedRoute,
  ) {

  }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  ResponseFormInit() {
    this.De4614Form = this.fb.group({
      id                  : [''                     ],
      claimId             : [''                     ],
      claimantName        : ['', Validators.required],
      socialSecurityNumber: ['', Validators.required],
      dateMailed          : ['', Validators.required],
      benefitYearBeganDate: ['', Validators.required],
    });
  }

  get fc() { return this.De4614Form.controls; }
  get fv() { return this.De4614Form.value; }
  get fvalid() { return this.De4614Form.valid; }

  submitDe4614Form() {
    this.formSubmitted = true;
    if (this.De4614Form.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id);
    this.fc.claimId.setValue(data.claimId);
    this.fc.claimantName.setValue(data.claimantName);
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber);
    this.fc.dateMailed.setValue(this.aps.formatDate(data.dateMailed));
    this.fc.benefitYearBeganDate.setValue(this.aps.formatDate(data.benefitYearBeganDate));
  }

  getFormDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 1;
    this.cas.getResponsetoEmployer(this.claimId)
      .subscribe((res) => {
        this.rteDetails = res;
        this.setFormvalues(this.rteDetails);
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.dateMailed           = this.aps.formatDate(this.fv.dateMailed          );
      this.fv.benefitYearBeganDate = this.aps.formatDate(this.fv.benefitYearBeganDate);

      this.cas.updateResponsetoEmployer(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
    
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.ResponseFormInit();
    this.getFormDetails();
  }
}
