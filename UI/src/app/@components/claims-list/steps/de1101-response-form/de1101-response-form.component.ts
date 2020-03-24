import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';


import { TabsetComponent } from 'ngx-bootstrap';


import { AppService       } from 'app/@services/app.service'
import { ClaimsService    } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-de1101-response-form',
  templateUrl: './de1101-response-form.component.html',
  styleUrls: ['./de1101-response-form.component.scss']
})
export class De1101ResponseFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public de1101ResponseInitiateForm: FormGroup;
  public formSubmitted: boolean = false;

  public claimId: number;
  public responseFormDetails: any = []

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
  de1101ResponseFormInit() {
    this.de1101ResponseInitiateForm = this.fb.group({
      id                  : [''                     ],
      address             : ['', Validators.required],
      lausdMailDate       : ['', Validators.required],
      bybClaimDate        : ['', Validators.required],
      effectiveDateOfClaim: ['', Validators.required],
      dueDate             : ['', Validators.required],
      claimantName        : ['', Validators.required],
      socialSecurityNumber: ['', Validators.required],
      lausdResponse       : ['', Validators.required],
      issuesList          : ['', Validators.required],
      printName           : ['', Validators.required],
      phoneNumber         : ['', Validators.required],
      signature           : ['', Validators.required],
      title               : ['', Validators.required],
      date                : ['', Validators.required],
      attachedDocument    : ['', Validators.required],
    });
  }

  get fc() { return this.de1101ResponseInitiateForm.controls; }

  submitDE1101ResponseInitiateForm() {
    this.formSubmitted = true;
    if (this.de1101ResponseInitiateForm.invalid) { return; }
  }

  de1101ResponseFormSetValues(data) {
    this.fc.id.setValue(data.id)
    this.fc.address.setValue(data.address)
    this.fc.lausdMailDate.setValue(data.lausdMailDate)
    this.fc.bybClaimDate.setValue(data.bybClaimDate)
    this.fc.effectiveDateOfClaim.setValue(data.effectiveDateOfClaim)
    this.fc.dueDate.setValue(data.dueDate)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.lausdResponse.setValue(data.lausdResponse)
    this.fc.issuesList.setValue(data.issuesList)
    this.fc.printName.setValue(data.printName)
    this.fc.phoneNumber.setValue(data.phoneNumber)
    this.fc.signature.setValue(data.signature)
    this.fc.title.setValue(data.title)
    this.fc.attachedDocument.setValue(data.attachedDocument)
  }

  disableDe1101ResponseFormField() {
    this.fc.claimantName.disable();
    this.fc.socialSecurityNumber.disable();
    this.fc.phoneNumber.disable();
  }

  getDe1101ResponseFormDetail() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id'))
    this.claimId = 2
    this.cas.getClaimResponse(this.claimId)
      .subscribe(
        (res) => {
          this.responseFormDetails = res;
          this.de1101ResponseFormSetValues(this.responseFormDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveDe1101ResponseForm() {
    if (this.de1101ResponseInitiateForm.valid) {
      this.cas.updateClaimResponse(this.de1101ResponseInitiateForm.value)
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
    this.de1101ResponseFormInit();
    this.getDe1101ResponseFormDetail();
    this.disableDe1101ResponseFormField();
  }


}
