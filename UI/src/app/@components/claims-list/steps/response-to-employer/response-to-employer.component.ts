import { Component, OnInit, ElementRef, ViewChild, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-response-to-employer',
  templateUrl: './response-to-employer.component.html',
  styleUrls: ['./response-to-employer.component.scss']
})
export class ResponseToEmployerComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  public rteDetails: any = []
  public claimId: number;

  // form setion var 
  De4614Form: FormGroup;
  formSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private tort: ToastrService,
    private route: ActivatedRoute,
  ) {

  }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  ResponseFormInit() {
    this.De4614Form = this.fb.group({
      id                   : [''                     ],
      claimId              : [''                     ],
      claimantName         : ['', Validators.required],
      socialSecurityNumber : ['', Validators.required],
      dateMailed           : ['', Validators.required],
      benefitYearBegan     : ['', Validators.required],
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
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.dateMailed.setValue(this.aps.formatDate(data.dateMailed))
    this.fc.benefitYearBegan.setValue(this.aps.formatDate(data.benefitYearBegan))
  }

  getFormDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 1
    this.cas.getResponsetoEmployer(this.claimId)
      .subscribe(
        (res) => {
          this.rteDetails = res;
          this.setFormvalues(this.rteDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveForm() {
    this.fv.dateMailed           = this.aps.formatDate(this.fv.dateMailed          )
    this.fv.benefitYearBegan = this.aps.formatDate(this.fv.benefitYearBegan)

    console.log(this.fv)
    if (this.fvalid) {
      this.cas.updateResponsetoEmployer(this.fv)
        .subscribe(
          (res) => {
            this.tort.success('claim', 'claim successfully updated', { timeOut: 5000, });
          },
          (error) => {
            console.log('error caught in batch detail update', error)
          }
        )
    }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.ResponseFormInit()
    this.getFormDetails()
  }
}
