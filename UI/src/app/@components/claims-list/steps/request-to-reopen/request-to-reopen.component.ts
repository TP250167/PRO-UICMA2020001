import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-request-to-reopen',
  templateUrl: './request-to-reopen.component.html',
  styleUrls: ['./request-to-reopen.component.scss']
})
export class RequestToReopenComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;


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
    private tort: ToastrService,
    private route: ActivatedRoute,
  ) {

  }


  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  reopenFormInit() {
    this.roForm = this.fb.group({
      id                          : [''                     ],
      claimId                     : [''                     ],
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
      .subscribe(
        (res) => {
          this.reopenFormDetail = res;
          this.setFormvalues(this.reopenFormDetail)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }


  saveForm() {

    if (this.fvalid) {

      this.fv.mailDate    = this.aps.formatDate(this.fv.mailDate   )
      this.fv.hearingDate = this.aps.formatDate(this.fv.hearingDate)
      this.fv.hearingTime = this.aps.formatDate(this.fv.hearingTime)

      this.cas.updateRequestToReopen(this.fv)
        .subscribe(
          (res) => {
            this.tort.success('reopenFrom', 'reopenForm successfully updated', { timeOut: 5000, });
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
    this.reopenFormInit()
    this.getFormDetails()
  }


}
