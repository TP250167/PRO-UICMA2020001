import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-claim-init',
  templateUrl: './claim-init.component.html',
  styleUrls: ['./claim-init.component.scss']
})

export class ClaimInitComponent implements OnInit {

  // form setion var 
  public cliamInitiateForm: FormGroup;
  public formSubmitted: boolean = false;

  public claimDetail: any = []
  public formId: number;

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) {

  }

  // form section 
  claimFormInit() {
    this.cliamInitiateForm = this.fb.group({
      id                   : [''                                                       ],
      claimId              : [''                                                       ],
      claimantName         : ['', Validators.required                                  ],
      employeeNumber       : ['', Validators.required                                  ],
      gender               : ['', Validators.required                                  ],
      socialSecurityNumber : ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      address              : ['', Validators.required                                  ],
      city                 : ['', Validators.required                                  ],
      state                : ['', Validators.required                                  ],
      zipcode              : ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      mailDate             : ['', Validators.required                                  ],
      protestDecision      : ['', Validators.required                                  ],
      additionalClaim      : ['', Validators.required                                  ],
      claimantStatus       : ['', Validators.required                                  ],
      separatedReason      : [null                                                     ],
      benefitYearBeginning : ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      effectiveDateOfClaim : ['', Validators.required                                  ],
      receivedDate         : ['', Validators.required                                  ],
      lastDateWorked       : ['', Validators.required                                  ],
      reasonForSeparation  : ['', Validators.required                                  ],
      dateMailedToEDD      : ['', Validators.required                                  ],
      deadLineDate         : ['', Validators.required                                  ],
      claimNotes           : [null                                                     ],
    });
  }

  get fc() { return this.cliamInitiateForm.controls; }
  get fv() { return this.cliamInitiateForm.value; }
  get fvalid() { return this.cliamInitiateForm.valid; }

  submitCliamInitiateForm() {
    this.formSubmitted = true;
    if (this.cliamInitiateForm.invalid) { return; }
  }

  claimFormSetValues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.employeeNumber.setValue(data.employeeNumber)
    this.fc.gender.setValue(data.gender)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.address.setValue(data.address)
    this.fc.city.setValue(data.city)
    this.fc.state.setValue(data.state)
    this.fc.zipcode.setValue(data.zipcode)
    this.fc.mailDate.setValue(this.aps.formatDate(data.mailDate))
    this.fc.protestDecision.setValue(data.protestDecision)
    this.fc.additionalClaim.setValue(data.additionalClaim)
    this.fc.claimantStatus.setValue(data.claimantStatus)
    this.fc.separatedReason.setValue(data.separatedReason)
    this.fc.benefitYearBeginning.setValue(data.benefitYearBeginning)
    this.fc.effectiveDateOfClaim.setValue(this.aps.formatDate(data.effectiveDateOfClaim))
    this.fc.receivedDate.setValue(this.aps.formatDate(data.receivedDate))
    this.fc.lastDateWorked.setValue(this.aps.formatDate(data.lastDateWorked))
    this.fc.reasonForSeparation.setValue(data.reasonForSeparation)
    this.fc.dateMailedToEDD.setValue(this.aps.formatDate(data.dateMailedToEDD))
    this.fc.deadLineDate.setValue(this.aps.formatDate(data.deadLineDate))
    this.fc.claimNotes.setValue(data.claimNotes)
  }

  claimFormConditionCheck() {

    const sepReason = this.cliamInitiateForm.get('separatedReason');

    this.cliamInitiateForm.get('claimantStatus').valueChanges
      .subscribe(value => {
        if (value == 'Separated') {
          sepReason.setValidators([Validators.required])
        } else {
          sepReason.setValidators(null)
        }
        sepReason.updateValueAndValidity()
      });
  }

  getClaimDetail() {
    this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    // this.formId = 1
    this.cas.getClaim(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.claimDetail = res;
          this.claimFormSetValues(this.claimDetail)
        }
      })
  }

  saveClaim() {

    if (this.fvalid) {

      this.fv.mailDate = this.aps.formatDate(this.fv.mailDate)
      this.fv.receivedDate= this.aps.formatDate(this.fv.receivedDate)
      this.fv.effectiveDateOfClaim = this.aps.formatDate(this.fv.effectiveDateOfClaim)
      this.fv.lastDateWorked = this.aps.formatDate(this.fv.lastDateWorked)
      this.fv.dateMailedToEDD = this.aps.formatDate(this.fv.dateMailedToEDD)
      this.fv.deadLineDate = this.aps.formatDate(this.fv.dateMailedToEDD)

      if(this.fv.id =='' || this.fv.id == null || this.fv.id == undefined) { this.fv.id = 0; }

      this.cas.updateClaim(this.fv)
        .subscribe(
          (res) => {
            (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
            this.getClaimDetail()
          }
        )
    }
    
  }

  ngOnInit() {
    this.claimFormInit();
    this.getClaimDetail();
    this.claimFormConditionCheck();
  }

}
