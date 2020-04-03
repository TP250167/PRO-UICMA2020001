import { Component, OnInit, Input} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-request-to-reopen',
  templateUrl: './request-to-reopen.component.html',
  styleUrls: ['./request-to-reopen.component.scss']
})
export class RequestToReopenComponent implements OnInit {

  @Input() uavalue: any;


  // form setion var 
  public roForm: FormGroup;
  public formSubmitted: boolean = false;

  public reopenFormDetail: any = []
  public formId: number;

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private route: ActivatedRoute,
  ) {

  }


  // form section 
  reopenFormInit() {
    this.roForm = this.fb.group({
      id                          : ['', Validators.required],
      claimId                     : ['', Validators.required],
      appealOfficeAddress         : ['', Validators.required],
      mailDate                    : ['', Validators.required],
      administrativeLawJudgeServer: ['', Validators.required],
      caseNumber                  : ['', Validators.required],
      hearingDate                 : ['', Validators.required],
      hearingTime                 : ['', Validators.required],
      claimantName                : ['', Validators.required],
      employer                    : ['', Validators.required],
      accountNumber               : ['', Validators.required],
      requestReason               : ['', Validators.required],
      signature                   : ['', Validators.required],
    });
  }

  get fc() { return this.roForm.controls; }
  get fv() { return this.roForm.value; }
  get fvalid() { return this.roForm.valid; }

  submitRoForm() {
    this.formSubmitted = true;
    if (this.roForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.roForm.controls.id.setValue(data.id)
    this.roForm.controls.claimId.setValue(data.claimId)
    this.roForm.controls.appealOfficeAddress.setValue(data.appealOfficeAddress)
    this.roForm.controls.mailDate.setValue(this.aps.formatDate(data.mailDate))
    this.roForm.controls.administrativeLawJudgeServer.setValue(data.administrativeLawJudgeServer)
    this.roForm.controls.caseNumber.setValue(data.caseNumber)
    this.roForm.controls.hearingDate.setValue(this.aps.formatDate(data.hearingDate))
    this.roForm.controls.hearingTime.setValue(this.aps.formatDate(data.hearingTime))
    this.roForm.controls.claimantName.setValue(data.claimantName)
    this.roForm.controls.employer.setValue(data.employer)
    this.roForm.controls.accountNumber.setValue(data.accountNumber)
    this.roForm.controls.requestReason.setValue(data.requestReason)
    this.roForm.controls.signature.setValue(data.signature)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 1
    this.cas.getRequestToReopen(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.reopenFormDetail = res;
          this.setFormvalues(this.reopenFormDetail)
        }
      })
  }


  saveForm() {

    if (this.fvalid) {

      this.fv.mailDate = this.aps.formatDate(this.fv.mailDate)
      this.fv.hearingDate = this.aps.formatDate(this.fv.hearingDate)
      this.fv.hearingTime = this.aps.formatDate(this.fv.hearingTime)

      this.cas.updateRequestToReopen(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })

    }

  }

  ngOnInit() {
    this.reopenFormInit()
    this.getFormDetails()
  }


}
