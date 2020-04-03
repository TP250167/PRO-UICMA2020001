import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-de1101-interview',
  templateUrl: './de1101-interview.component.html',
  styleUrls: ['./de1101-interview.component.scss']
})
export class De1101InterviewComponent implements OnInit {

  @Input() uavalue: any;

  public De1101ivForm: FormGroup;
  public formSubmitted: boolean = false;

  public De1101ivFormDetail: any = []
  public formId: number;

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ){

  }


  // form section 
  de1101InterviewFormInit() {
    this.De1101ivForm = this.fb.group({
      id                    : ['', Validators.required],
      claimId               : ['', Validators.required],
      address               : ['', Validators.required],
      lausdFaxDate          : ['', Validators.required],
      bybClaimDate          : ['', Validators.required],
      effectiveDate         : ['', Validators.required],
      claimantName          : ['', Validators.required],
      socialSecurityNumber  : ['', Validators.required],
      issuesList            : ['', Validators.required],
      status                : ['', Validators.required],
      time                  : ['', Validators.required],
      detInterviewer        : ['', Validators.required],
      interviewerPhoneNumber: ['', Validators.required],
      printName             : ['', Validators.required],
      phoneNumber           : ['', Validators.required],
      signature             : ['', Validators.required],
      title                 : ['', Validators.required],
      date                  : ['', Validators.required],
    });
  }


  get fc() { return this.De1101ivForm.controls; }
  get fv() { return this.De1101ivForm.value; }
  get fvalid() { return this.De1101ivForm.valid; }

  submitDe1101ivForm() {
    this.formSubmitted = true;
    if (this.De1101ivForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.address.setValue(data.address)
    this.fc.lausdFaxDate.setValue(this.aps.formatDate(data.lausdFaxDate))
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
    this.fc.effectiveDate.setValue(this.aps.formatDate(data.effectiveDate))
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.issuesList.setValue(data.issuesList)
    this.fc.status.setValue(data.status)
    this.fc.time.setValue(data.time)
    this.fc.detInterviewer.setValue(data.detInterviewer)
    this.fc.interviewerPhoneNumber.setValue(data.interviewerPhoneNumber)
    this.fc.printName.setValue(data.printName)
    this.fc.phoneNumber.setValue(data.phoneNumber)
    this.fc.signature.setValue(data.signature)
    this.fc.title.setValue(data.title)
    this.fc.date.setValue(this.aps.formatDate(data.date))
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id'))
    this.formId = 11
    this.cas.getClaimInterview(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.De1101ivFormDetail = res;
          this.setFormvalues(this.De1101ivFormDetail)
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.lausdFaxDate = this.aps.formatDate(this.fv.lausdFaxDate)
      this.fv.bybClaimDate = this.aps.formatDate(this.fv.bybClaimDate)
      this.fv.effectiveDate = this.aps.formatDate(this.fv.effectiveDate)
      this.fv.date = this.aps.formatDate(this.fv.date)

      this.cas.updateClaimInterview(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
    
  }

  ngOnInit() {
    this.de1101InterviewFormInit()
    this.getFormDetails()
  }

}
