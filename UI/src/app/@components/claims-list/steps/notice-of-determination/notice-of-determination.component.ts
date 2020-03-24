import { Component, OnInit, TemplateRef, ElementRef, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';

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

  public claimId: number;
  public nodDetails : any = []

  // form section var 
  noticeDeterminationForm: FormGroup;
  formSubmitted: boolean = false;

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private tort: ToastrService,
    private route: ActivatedRoute,
    private datePipe: DatePipe
  ) { }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  //form section
  noticeDeterminationFormInit() {
    this.noticeDeterminationForm = this.fb.group({
      mailedDate          : ['', Validators.required],
      benefitYearBegan    : ['', Validators.required],
      socialSecurityNumber: ['', Validators.required],
      fieldOffice         : ['', Validators.required],
      decision            : ['', Validators.required],
    });
  }

  get fc() { return this.noticeDeterminationForm.controls; }

  submitNoticeDeterminationForm() {
    this.formSubmitted = true;
    if (this.noticeDeterminationForm.invalid) { return; }
  }

  NoticeDeterminationFormSetValues(data) {
    this.fc.mailedDate.setValue(this.datePipe.transform(data.mailedDate, 'MM-dd-yyyy'))
    this.fc.benefitYearBegan.setValue(this.datePipe.transform(data.benefitYearBegan, 'MM-dd-yyyy'))
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.fieldOffice.setValue(data.fieldOffice)
    this.fc.decision.setValue(data.decision)
  }

  getNoticeDeterminationDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 2; 
    this.cas.getClaimDetermination(this.claimId)
      .subscribe(
        (res) => {
          this.nodDetails = res;
          this.NoticeDeterminationFormSetValues(this.nodDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveNoticeDetermination() {
    if (this.noticeDeterminationForm.valid) {
      console.log(this.noticeDeterminationForm.value)
      // this.cas.updateClaimDetermination(this.noticeDeterminationForm.value)
      //   .subscribe(
      //     (res) => {
      //       this.tort.success('updated', 'successfully updated', { timeOut: 5000, });
      //       console.log(res)
      //     },
      //     (error) => {
      //       console.log('error caught in batch detail update', error)
      //     }
      //   )
    }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.noticeDeterminationFormInit()
    this.getNoticeDeterminationDetails()
  }

}
