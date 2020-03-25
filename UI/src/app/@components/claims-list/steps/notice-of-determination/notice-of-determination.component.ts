import { Component, OnInit, TemplateRef, ElementRef, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-notice-of-determination',
  templateUrl: './notice-of-determination.component.html',
  styleUrls: ['./notice-of-determination.component.scss']
})
export class NoticeOfDeterminationComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  public formId: number;
  public nodDetails : any = []

  // form section var 
  nodForm: FormGroup;
  formSubmitted: boolean = false;

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private tort: ToastrService,
    private route: ActivatedRoute,
  ) { }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  //form section
  nodFormInit() {
    this.nodForm = this.fb.group({
      id                  : [''],
      claimId             : [''],
      mailedDate          : ['', Validators.required],
      benefitYearBegan    : ['', Validators.required],
      socialSecurityNumber: ['', Validators.required],
      fieldOffice         : ['', Validators.required],
      decision            : ['', Validators.required],
    });
  }

  get fc() { return this.nodForm.controls; }
  get fv() { return this.nodForm.value; }
  get fvalid() { return this.nodForm.valid; }

  submitnodForm() {
    this.formSubmitted = true;
    if (this.nodForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.mailedDate.setValue(this.aps.formatDate(data.mailedDate))
    this.fc.benefitYearBegan.setValue(this.aps.formatDate(data.benefitYearBegan))
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.fieldOffice.setValue(data.fieldOffice)
    this.fc.decision.setValue(data.decision)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 1; 
    this.cas.getClaimDetermination(this.formId)
      .subscribe(
        (res) => {
          this.nodDetails = res;
          this.setFormvalues(this.nodDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveForm() {
    if (this.fvalid) {
      this.fv.mailedDate       = this.aps.formatDate(this.fv.mailedDate       )
      this.fv.benefitYearBegan = this.aps.formatDate(this.fv.benefitYearBegan )
      
      console.log(this.fv)
      this.cas.updateClaimDetermination(this.nodForm.value)
        .subscribe(
          (res) => {
            this.tort.success('updated', 'successfully updated', { timeOut: 5000, });
            console.log(res)
          },
          (error) => {
            console.log('error caught in batch detail update', error)
          }
        )
    }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.nodFormInit()
    this.getFormDetails()
  }

}
