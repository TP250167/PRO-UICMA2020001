import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-alj-decision',
  templateUrl: './alj-decision.component.html',
  styleUrls: ['./alj-decision.component.scss']
})
export class AljDecisionComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public aljdForm: FormGroup;
  public formSubmitted: boolean = false;

  public aljdDetail : any =[];
  public formId : number;

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private route: ActivatedRoute,
    private tort: ToastrService,
  ) { }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  aljFormInit() {
    this.aljdForm = this.fb.group({
      id                    : [''                     ],
      claimId               : [''                     ],
      claimName             : ['', Validators.required],
      employerInfo          : ['', Validators.required],
      aljName               : ['', Validators.required],
      mailDate              : ['', Validators.required],
      caseNumber            : ['', Validators.required],
      formerlyCaseNumber    : ['', Validators.required],
      applicationReopenDate : ['', Validators.required],
      hearingDate           : ['', Validators.required],
      hearingPlace          : ['', Validators.required],
      partiesAppering       : ['', Validators.required],
      decision              : ['', Validators.required],
    });
  }

  get fc() { return this.aljdForm.controls; }
  get fv() { return this.aljdForm.value; }
  get fvalid() { return this.aljdForm.valid; }


  submitAljForm() {
    this.formSubmitted = true;
    if (this.aljdForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimName.setValue(data.claimName)
    this.fc.employerInfo.setValue(data.employerInfo)
    this.fc.aljName.setValue(data.aljName)
    this.fc.mailDate.setValue(this.aps.formatDate(data.mailDate)) 
    this.fc.caseNumber.setValue(data.caseNumber)
    this.fc.formerlyCaseNumber.setValue(data.formerlyCaseNumber)
    this.fc.applicationReopenDate.setValue(this.aps.formatDate(data.applicationReopenDate))
    this.fc.hearingDate.setValue(this.aps.formatDate(data.hearingDate))
    this.fc.hearingPlace.setValue(data.hearingPlace)
    this.fc.partiesAppering.setValue(data.partiesAppering)
    this.fc.decision.setValue(data.decision)
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 1 ; 
    this.cas.getALJDecision(this.formId)
      .subscribe(
        (res) => {
          this.aljdDetail = res;
          this.setFormvalues(this.aljdDetail)
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

      this.cas.updateALJDecision(this.aljdForm.value)
        .subscribe(
          (res) => {
            this.tort.success('claim', 'claim successfully updated', { timeOut: 5000, });
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
    this.aljFormInit()
    this.getFormDetails()
  }

}
