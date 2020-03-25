import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

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
  public De1545AppealForm: FormGroup;
  public formSubmitted: boolean = false;


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
  de1545AppealFormInit() {
    this.De1545AppealForm = this.fb.group({
      id                         : [''],
      claimId                    : [''],
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

  get fc() { return this.De1545AppealForm.controls; }
  get fv() { return this.De1545AppealForm.value; }
  get fvalid() { return this.De1545AppealForm.valid; }

  submitDe1545AppealForm() {
    this.formSubmitted = true;
    if (this.De1545AppealForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.fieldOfficeAddress.setValue(data.fieldOfficeAddress)
    this.fc.lausdFaxDate.setValue(this.aps.formatDate(data.lausdFaxDate))
    this.fc.lausdAccountNumber.setValue(data.lausdAccountNumber)
    this.fc.bybClaimDate.setValue(data.bybClaimDate)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.lausdEligibilityInformation.setValue(data.lausdEligibilityInformation)
    this.fc.printName.setValue(data.printName)
    this.fc.userPhoneNumber.setValue(data.userPhoneNumber)
    this.fc.signature.setValue(data.signature)
    this.fc.title.setValue(data.title)
    this.fc.date.setValue(this.aps.formatDate(data.date))
  }

  getFormDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 1
    this.cas.getWagesAppeal(this.claimId)
      .subscribe(
        (res) => {
          this.appealFormDetails = res;
          console.log(this.appealFormDetails)
          this.setFormvalues(this.appealFormDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveForm() {
    console.log(this.fv)
    if (this.fvalid) {
      console.log(this.fv,"test")
      this.cas.updateWagesAppeal(this.fv)
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
    this.cs.tabincLimit = 2
    this.de1545AppealFormInit()
    this.getFormDetails()
  }



}
