import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-acknowledgement',
  templateUrl: './acknowledgement.component.html',
  styleUrls: ['./acknowledgement.component.scss']
})
export class AcknowledgementComponent implements OnInit {

  @Input() uavalue: any;

  // form setion var 
  public acknForm: FormGroup;
  public formSubmitted: boolean = false;

  public acknFormDetails: any = [];
  public formId: number;

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) { }

  // form section 
  acknFormInit() {
    this.acknForm = this.fb.group({
      id               : ['', Validators.required],
      claimId          : ['', Validators.required],
      claimantName     : ['', Validators.required],
      abCaseNumber     : ['', Validators.required],
      aljDecisionNumber: ['', Validators.required],
      appellant        : ['', Validators.required],
      dateMailed       : ['', Validators.required],
    });
  }

  get fc() { return this.acknForm.controls; }
  get fv() { return this.acknForm.value; }
  get fvalid() { return this.acknForm.valid; }

  submitAcknForm() {
    this.formSubmitted = true;
    if (this.acknForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.abCaseNumber.setValue(data.abCaseNumber)
    this.fc.aljDecisionNumber.setValue(data.aljDecisionNumber)
    this.fc.appellant.setValue(data.appellant)
    this.fc.dateMailed.setValue(this.aps.formatDate(data.dateMailed))
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) ;
    this.formId = 1;
    this.cas.getAcknowledgement(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.acknFormDetails = res;
          this.setFormvalues(this.acknFormDetails);
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.dateMailed = this.aps.formatDate(this.fv.dateMailed)

      this.cas.updateAcknowledgement(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.acknFormInit()
    this.getFormDetails()
  }

}
