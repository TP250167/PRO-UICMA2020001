import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-notice-of-hearing',
  templateUrl: './notice-of-hearing.component.html',
  styleUrls: ['./notice-of-hearing.component.scss']
})
export class NoticeOfHearingComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 

  public hearingDetail: any = [];
  public formId: number;

  public nohForm: FormGroup;
  public formSubmitted: boolean = false;


  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    public  cas  : ClaimsApiService,
    public  route: ActivatedRoute  ,
  ) {

  }


  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  hearingFormInit() {
    this.nohForm = this.fb.group({
      id               : [''                     ],
      claimId          : [''                     ],
      caseNumber       : ['', Validators.required],
      claimantName     : ['', Validators.required],
      employerInfo     : ['', Validators.required],
      hearingDate      : ['', Validators.required],
      hearingTime      : ['', Validators.required],
      hearingPlace     : ['', Validators.required],
      issueCode        : ['', Validators.required],
      issueContext     : ['', Validators.required],
      appellantName    : ['', Validators.required],
      claimantAppellant: ['', Validators.required],
      lausdAppelant    : ['', Validators.required],

    });
  }

  get fc() { return this.nohForm.controls; }
  get fv() { return this.nohForm.value; }
  get fvalid() { return this.nohForm.valid; }

  submitnohForm() {
    this.formSubmitted = true;
    if (this.nohForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.caseNumber.setValue(data.caseNumber)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.employerInfo.setValue(data.employerInfo)
    this.fc.hearingDate.setValue(this.aps.formatDate(data.hearingDate))
    this.fc.hearingTime.setValue(this.aps.formatDate(data.hearingTime))
    this.fc.hearingPlace.setValue(data.hearingPlace)
    this.fc.issueCode.setValue(data.issueCode)
    this.fc.issueContext.setValue(data.issueContext)
    this.fc.appellantName.setValue(data.appellantName)
    this.fc.claimantAppellant.setValue(data.claimantAppellant)
    this.fc.lausdAppelant.setValue(data.lausdAppelant)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 1
    this.cas.getHearingNotification(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.hearingDetail = res;
          this.setFormvalues(this.hearingDetail)
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.hearingDate = this.aps.formatDate(this.fv.hearingDate)
      this.fv.hearingTime = this.aps.formatDate(this.fv.hearingTime)

      this.cas.updateHearingNotification(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.cs.tabincLimit = 2
    this.hearingFormInit()
    this.getFormDetails()
  }

}
