import { Component, OnInit, Input} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-notice-of-determination',
  templateUrl: './notice-of-determination.component.html',
  styleUrls: ['./notice-of-determination.component.scss']
})
export class NoticeOfDeterminationComponent implements OnInit {

  @Input() uavalue: any;

  
  // form section var 
  public nodForm: FormGroup;
  public formSubmitted: boolean = false;
  
  public formId: number;
  public nodDetails: any = []

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) { }

  //form section
  nodFormInit() {
    this.nodForm = this.fb.group({
      id                  : ['', Validators.required],
      claimId             : ['', Validators.required],
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
      .subscribe((res) => {
        if(res != null) {
          this.nodDetails = res;
          this.setFormvalues(this.nodDetails)
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.mailedDate = this.aps.formatDate(this.fv.mailedDate)
      this.fv.benefitYearBegan = this.aps.formatDate(this.fv.benefitYearBegan)

      this.cas.updateClaimDetermination(this.nodForm.value)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
    
  }

  ngOnInit() {
    this.nodFormInit()
    this.getFormDetails()
  }

}
