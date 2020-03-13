import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService       } from '../../../../services/app.service'
import { ClaimsService    } from '../../../../services/claims.service'
import { ClaimsApiService } from '../../../../services/claims-api.service'

import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-claim-init',
  templateUrl: './claim-init.component.html',
  styleUrls: ['./claim-init.component.scss']
})

export class ClaimInitComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public cliamInitiateForm: FormGroup;
  public cifSubmitted: boolean = false;


  constructor( 
    public  aps  : AppService,
    public  cs   : ClaimsService,
    private fb   : FormBuilder,
    private cas  : ClaimsApiService,
    private tort : ToastrService
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  claimFormInit() {
    this.cliamInitiateForm = this.fb.group({
      claimName        : ['', Validators.required],
      address          : ['', Validators.required],
      city             : ['', Validators.required],
      state            : ['', Validators.required],
      zip              : ['', Validators.required],
      mailDate         : ['', Validators.required],
      additionalClaim  : ['', Validators.required],
      receiveDate      : ['', Validators.required],
      ssn              : ['', Validators.required],
      EffectiveDate    : ['', Validators.required],
      lastDateWorked   : ['', Validators.required],
      separation       : ['', Validators.required],
      byb              : ['', Validators.required],
      mailDateEDD      : ['', Validators.required],
    });
  }

  get cfi() { return this.cliamInitiateForm.controls; }

  submitCliamInitiateForm() {
    this.cifSubmitted = true;
    if (this.cliamInitiateForm.invalid) { return; }
  }

  showSuccess() {
    this.tort.success('Hello world!', 'Toastr fun!', {
      timeOut: 1000000000,
    });
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.claimFormInit();
  }

}
