import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

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

  @Input() uavalue: any;

  public appealFormDetails: any = []
  public claimId: number;

  // form setion var 
  public De1545AppealForm: FormGroup;
  public formSubmitted: boolean = false;


  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private tort : ToastrService   ,
    private route: ActivatedRoute  ,
  ) {

  }

  // form section 
  de1545AppealFormInit() {
    this.De1545AppealForm = this.fb.group({
      id                         : ['', Validators.required],
      claimId                    : ['', Validators.required],
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
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
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
      .subscribe((res) => {
        if(res != null) {
          this.appealFormDetails = res;
          this.setFormvalues(this.appealFormDetails);
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.lausdFaxDate = this.aps.formatDate(this.fv.lausdFaxDate);
      this.fv.bybClaimDate = this.aps.formatDate(this.fv.bybClaimDate);
      this.fv.date = this.aps.formatDate(this.fv.date);

      this.cas.updateWagesAppeal(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.de1545AppealFormInit();
    this.getFormDetails();
  }

}
