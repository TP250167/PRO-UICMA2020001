import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';


import { TabsetComponent } from 'ngx-bootstrap';


import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-de1545-appeal-form',
  templateUrl: './de1545-appeal-form.component.html',
  styleUrls: ['./de1545-appeal-form.component.scss']
})
export class DE1545AppealFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  public appealFormDetails: any = []
  public claimId: number;

  // form setion var 
  public de1545AppealInitiateForm: FormGroup;
  public formSubmitted: boolean = false;


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
  de1545AppealFormInit() {
    this.de1545AppealInitiateForm = this.fb.group({
      fieldOfficeAddress         : ['', Validators.required],
      lausdFaxDate               : ['', Validators.required],
      lausdAccountNumber         : ['', Validators.required],
      bybClaimDate               : ['', Validators.required],
      claimantName               : ['', Validators.required],
      socialSecurityNumber       : ['', Validators.required],
      lausdEligibilityInformation: ['', Validators.required],
      printName                  : ['', Validators.required],
      userPhoneNumber            : ['', Validators.required],
      signature                  : ['', Validators.required],
      title                      : ['', Validators.required],
      date                       : ['', Validators.required],
    });
  }

  get fc() { return this.de1545AppealInitiateForm.controls; }

  submitDE1545AppealInitiateForm() {
    this.formSubmitted = true;
    if (this.de1545AppealInitiateForm.invalid) { return; }
  }

  dE1545AppealFormSetValues(data) {
    this.fc.fieldOfficeAddress.setValue(data.fieldOfficeAddress)
    this.fc.lausdFaxDate.setValue(data.lausdFaxDate)
    this.fc.lausdAccountNumber.setValue(data.lausdAccountNumber)
    this.fc.bybClaimDate.setValue(data.bybClaimDate)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.lausdEligibilityInformation.setValue(data.lausdEligibilityInformation)
    this.fc.printName.setValue(data.printName)
    this.fc.userPhoneNumber.setValue(data.userPhoneNumber)
    this.fc.signature.setValue(data.signature)
    this.fc.title.setValue(data.title)
    this.fc.date.setValue(data.date)
  }

  getdE1545AppealFormDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 1542
    this.cas.getWagesAppeal(this.claimId)
      .subscribe(
        (res) => {
          this.appealFormDetails = res;
          this.dE1545AppealFormSetValues(this.appealFormDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveDE1545AppealForm() {
    console.log(this.de1545AppealInitiateForm.value)
    // if (this.de1545AppealInitiateForm.valid) {
    //   this.cas.updateWagesAppeal(this.de1545AppealInitiateForm.value)
    //     .subscribe(
    //       (res) => {
    //         this.tort.success('claim', 'claim successfully updated', { timeOut: 5000, });
    //         console.log(res)
    //       },
    //       (error) => {
    //         console.log('error caught in batch detail update', error)
    //       }
    //     )

    // }
  }


  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de1545AppealFormInit()
  }



}
