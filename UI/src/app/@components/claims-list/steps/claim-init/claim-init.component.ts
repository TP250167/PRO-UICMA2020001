import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-claim-init',
  templateUrl: './claim-init.component.html',
  styleUrls: ['./claim-init.component.scss']
})

export class ClaimInitComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;



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


  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  claimFormInit() {
    this.cliamInitiateForm = this.fb.group({
      id                  : [''                                                       ],
      claimId             : [''                                                       ],
      claimantName        : ['', Validators.required                                  ],
      address             : ['', Validators.required                                  ],
      city                : ['', Validators.required                                  ],
      state               : ['', Validators.required                                  ],
      zipcode             : ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      mailDate            : ['', Validators.required                                  ],
      additionalClaim     : ['', Validators.required                                  ],
      receiveDate         : ['', Validators.required                                  ],
      socialSecurityNumber: ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      effectiveDateOfClaim: ['', Validators.required                                  ],
      lastDateWorked      : ['', Validators.required                                  ],
      reasonForSeparation : ['', Validators.required                                  ],
      benefitYearBeginning: ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      dateMailedToEDD     : ['', Validators.required                                  ],
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
    this.fc.address.setValue(data.address)
    this.fc.city.setValue(data.city)
    this.fc.state.setValue(data.state)
    this.fc.zipcode.setValue(data.zipcode)
    this.fc.mailDate.setValue(this.aps.formatDate(data.mailDate))
    this.fc.additionalClaim.setValue(data.additionalClaim)
    this.fc.receiveDate.setValue(this.aps.formatDate(data.receiveDate))
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.effectiveDateOfClaim.setValue(this.aps.formatDate(data.effectiveDateOfClaim))
    this.fc.lastDateWorked.setValue(this.aps.formatDate(data.lastDateWorked))
    this.fc.reasonForSeparation.setValue(data.reasonForSeparation)
    this.fc.benefitYearBeginning.setValue(data.benefitYearBeginning)
    this.fc.dateMailedToEDD.setValue(this.aps.formatDate(data.dateMailedToEDD))
  }

  getClaimDetail() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.formId = 1542
    this.cas.getClaim(this.formId)
      .subscribe((res) => {
        this.claimDetail = res;
        this.claimFormSetValues(this.claimDetail)
      })
  }

  saveClaim() {

    if (this.fvalid) {

      this.fv.claimantStatus = 'Active'
      this.fv.mailDate = this.aps.formatDate(this.fv.mailDate)
      this.fv.receiveDate = this.aps.formatDate(this.fv.receiveDate)
      this.fv.effectiveDateOfClaim = this.aps.formatDate(this.fv.effectiveDateOfClaim)
      this.fv.lastDateWorked = this.aps.formatDate(this.fv.lastDateWorked)
      this.fv.dateMailedToEDD = this.aps.formatDate(this.fv.dateMailedToEDD)

      this.cas.updateClaim(this.fv)
        .subscribe(
          (res) => {
            (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
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
