import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService       } from 'app/@services/app.service'
import { ClaimsService    } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-de1101-response-form',
  templateUrl: './de1101-response-form.component.html',
  styleUrls: ['./de1101-response-form.component.scss']
})
export class De1101ResponseFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public De1101Form: FormGroup;
  public formSubmitted: boolean = false;

  public formId: number;
  public responseFormDetails: any = []

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
  de1101ResponseFormInit() {
    this.De1101Form = this.fb.group({
      id                  : [''                     ],
      claimId             : [''                     ],
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

  get fc() { return this.De1101Form.controls; }
  get fv() { return this.De1101Form.value; }
  get fvalid() { return this.De1101Form.valid; }

  submitDe1101Form() {
    this.formSubmitted = true;
    if (this.De1101Form.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.address.setValue(data.address)
    this.fc.lausdMailDate.setValue(this.aps.formatDate(data.lausdMailDate))
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
    this.fc.effectiveDateOfClaim.setValue(this.aps.formatDate(data.effectiveDateOfClaim))
    this.fc.dueDate.setValue(this.aps.formatDate(data.dueDate))
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.lausdResponse.setValue(data.lausdResponse)
    this.fc.issuesList.setValue(data.issuesList)
    this.fc.printName.setValue(data.printName)
    this.fc.phoneNumber.setValue(data.phoneNumber)
    this.fc.signature.setValue(data.signature)
    this.fc.title.setValue(data.title)
    this.fc.date.setValue(this.aps.formatDate(data.date))
    this.fc.attachedDocument.setValue(data.attachedDocument)
  }

  formFeildDisable() {
    // this.fc.claimantName.disable();
    // this.fc.socialSecurityNumber.disable();
    // this.fc.phoneNumber.disable();
  }

  getFormDetails() {
    // this.formId = parseInt(this.route.snapshot.paramMap.get('id'))
    this.formId = 2;
    this.cas.getClaimResponse(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.responseFormDetails = res;
          this.setFormvalues(this.responseFormDetails);
        }
      })
  }

  saveForm() {
    
    if (this.fvalid) {
      
      this.fv.lausdMailDate        = this.aps.formatDate(this.fv.lausdMailDate        );
      this.fv.bybClaimDate         = this.aps.formatDate(this.fv.bybClaimDate         );
      this.fv.effectiveDateOfClaim = this.aps.formatDate(this.fv.effectiveDateOfClaim );
      this.fv.dueDate              = this.aps.formatDate(this.fv.dueDate              );
      this.fv.date                 = this.aps.formatDate(this.fv.date                 );

      this.cas.updateClaimResponse(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de1101ResponseFormInit();
    this.getFormDetails();
    this.formFeildDisable();
  }


}
