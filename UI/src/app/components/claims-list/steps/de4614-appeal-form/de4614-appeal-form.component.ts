import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '../../../../services/app.service'
import { ClaimsService  } from '../../../../services/claims.service'

@Component({
  selector: 'app-de4614-appeal-form',
  templateUrl: './de4614-appeal-form.component.html',
  styleUrls: ['./de4614-appeal-form.component.scss']
})
export class De4614AppealFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public de4614AppealInitiateForm: FormGroup;
  public bifSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  de4614AppealFormInit() {
    this.de4614AppealInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      lausdFaxDate           : ['', Validators.required],
      lausdAcNo              : ['', Validators.required],
      ClaimDateByb           : ['', Validators.required],
      de4614Date             : ['', Validators.required],
      claimantName           : ['', Validators.required],
      claimantSSN            : ['', Validators.required],
      lausdeInfo             : ['', Validators.required],
      printName              : ['', Validators.required],
      phoneNo                : ['', Validators.required],
      signature              : ['', Validators.required],
      title                  : ['', Validators.required],
      date                   : ['', Validators.required],
    });
  }

  get bfi() { return this.de4614AppealInitiateForm.controls; }

  submitDE4614AppealInitiateForm() {
    this.bifSubmitted = true;
    if (this.de4614AppealInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de4614AppealFormInit()
  }


}
