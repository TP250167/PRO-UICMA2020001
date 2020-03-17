import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';


import { TabsetComponent } from 'ngx-bootstrap';


import { AppService } from '../../../../services/app.service'
import { ClaimsService } from '../../../../services/claims.service'
import { ClaimsApiService } from '../../../../services/claims-api.service'

import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-claim-init',
  templateUrl: './claim-init.component.html',
  styleUrls: ['./claim-init.component.scss']
})

export class ClaimInitComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  
  public claimDetail: any = []
  public claimId: number ;

  // form setion var 
  public cliamInitiateForm: FormGroup;
  public cifSubmitted: boolean = false;

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
  claimFormInit() {
    this.cliamInitiateForm = this.fb.group({
      id: [''],
      claimantName: ['', Validators.required],
      address: ['', Validators.required],
      city: ['', Validators.required],
      state: ['', Validators.required],
      zipcode: ['', [Validators.required,Validators.pattern("^[0-9]*$")]],
      mailDate: ['', Validators.required],
      additionalClaim: ['', Validators.required],
      receiveDate: ['', Validators.required],
      socialSecurityNumber: ['', [Validators.required,Validators.pattern("^[0-9]*$")]],
      effectiveDateOfClaim: ['', Validators.required],
      lastDateWorked: ['', Validators.required],
      reasonForSeparation: ['', Validators.required],
      benefitYearBeginning: ['',[Validators.required,Validators.pattern("^[0-9]*$")]],
      dateMailedToEDD: ['', Validators.required],
    });
  }

  get cfi() { return this.cliamInitiateForm.controls; }

  submitCliamInitiateForm() {
    this.cifSubmitted = true;
    if (this.cliamInitiateForm.invalid) { return; }
  }

  claimFormSetValues(data) {
    this.cliamInitiateForm.controls.id.setValue(data.id)
    this.cliamInitiateForm.controls.claimantName.setValue(data.claimantName)
    this.cliamInitiateForm.controls.address.setValue(data.address)
    this.cliamInitiateForm.controls.city.setValue(data.city)
    this.cliamInitiateForm.controls.state.setValue(data.state)
    this.cliamInitiateForm.controls.zipcode.setValue(data.zipcode)
    this.cliamInitiateForm.controls.mailDate.setValue(this.datePipe.transform(data.mailDate, 'MM-dd-yyyy')) 
    this.cliamInitiateForm.controls.additionalClaim.setValue(data.additionalClaim)
    this.cliamInitiateForm.controls.receiveDate.setValue(this.datePipe.transform(data.receiveDate,'MM-dd-yyyy'))
    this.cliamInitiateForm.controls.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.cliamInitiateForm.controls.effectiveDateOfClaim.setValue(this.datePipe.transform(data.effectiveDateOfClaim, 'MM-dd-yyyy'))
    this.cliamInitiateForm.controls.lastDateWorked.setValue(this.datePipe.transform(data.lastDateWorked,'MM-dd-yyyy'))
    this.cliamInitiateForm.controls.reasonForSeparation.setValue(data.reasonForSeparation)
    this.cliamInitiateForm.controls.benefitYearBeginning.setValue(data.benefitYearBeginning)
    this.cliamInitiateForm.controls.dateMailedToEDD.setValue(this.datePipe.transform(data.dateMailedToEDD,'MM-dd-yyyy'))
  }

  getClaimDetail() {
    this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.cas.getClaim(this.claimId)
      .subscribe(
        (res) => {
          this.claimDetail = res;
          this.claimFormSetValues(this.claimDetail)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }


  saveClaim() {

    if (this.cliamInitiateForm.valid) {

      this.cliamInitiateForm.controls.id.setValue(this.claimDetail.id)
      this.cliamInitiateForm.value.claimantStatus       = 'Active'
      this.cliamInitiateForm.value.requestNumber        = this.claimId 
      this.cliamInitiateForm.value.mailDate             = this.datePipe.transform(this.cliamInitiateForm.value.mailDate, 'MM-dd-yyyy')
      this.cliamInitiateForm.value.receiveDate          = this.datePipe.transform(this.cliamInitiateForm.value.receiveDate, 'MM-dd-yyyy') 
      this.cliamInitiateForm.value.effectiveDateOfClaim = this.datePipe.transform(this.cliamInitiateForm.value.effectiveDateOfClaim, 'MM-dd-yyyy')
      this.cliamInitiateForm.value.lastDateWorked       = this.datePipe.transform(this.cliamInitiateForm.value.lastDateWorked, 'MM-dd-yyyy')
      this.cliamInitiateForm.value.dateMailedToEDD      = this.datePipe.transform(this.cliamInitiateForm.value.dateMailedToEDD, 'MM-dd-yyyy')

      this.cas.updateClaim(this.cliamInitiateForm.value)
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
    this.claimFormInit();
    this.getClaimDetail()
  }

}
