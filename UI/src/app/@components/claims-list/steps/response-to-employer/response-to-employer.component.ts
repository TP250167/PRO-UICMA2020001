import { Component, OnInit, ElementRef, ViewChild, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';


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
  responseInitiateForm: FormGroup;
  formSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private tort: ToastrService,
    private route: ActivatedRoute,
    private datePipe: DatePipe
  ) {

  }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  ResponseFormInit() {
    this.responseInitiateForm = this.fb.group({
      claimantName         : ['', Validators.required],
      socialSecurityNumber : ['', Validators.required],
      dateMailed           : ['', Validators.required],
      benefitYearBeganDate : ['', Validators.required],
    });
  }

  get fc() { return this.responseInitiateForm.controls; }

  submitResponseInitiateForm() {
    this.formSubmitted = true;
    if (this.responseInitiateForm.invalid) { return; }
    console.log(this.responseInitiateForm.value)
  }

  responseFormSetValues(data) {
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.dateMailed.setValue(this.datePipe.transform(data.dateMailed, 'MM-dd-yyyy'))
    this.fc.benefitYearBeganDate.setValue(this.datePipe.transform(data.benefitYearBeganDate, 'MM-dd-yyyy'))
  }

  getResponseFormDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 1
    this.cas.getResponsetoEmployer(this.claimId)
      .subscribe(
        (res) => {
          this.rteDetails = res;
          this.responseFormSetValues(this.rteDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveResponseForm(){
    console.log(this.responseInitiateForm.value)
    // if (this.responseInitiateForm.valid) { 
    //   this.cas.updateResponsetoEmployer(this.responseInitiateForm.value)
    //   .subscribe(
    //     (res) => {
    //       this.tort.success('claim', 'claim successfully updated', { timeOut: 5000, });
    //       console.log(res)
    //     },
    //     (error) => {
    //       console.log('error caught in batch detail update', error)
    //     }
    //   )
    // }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.ResponseFormInit()
    this.getResponseFormDetails()
  }
}
