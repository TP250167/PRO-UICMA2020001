import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService  } from '@services/claims.service'

@Component({
  selector: 'app-de1545-appeal-form',
  templateUrl: './de1545-appeal-form.component.html',
  styleUrls: ['./de1545-appeal-form.component.scss']
})
export class DE1545AppealFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public de1545AppealInitiateForm: FormGroup;
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
  de1545AppealFormInit() {
    this.de1545AppealInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      lausdFaxDate           : ['', Validators.required],
      lausdAcNo              : ['', Validators.required],
      ClaimDateByb           : ['', Validators.required],
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

  get bfi() { return this.de1545AppealInitiateForm.controls; }

  submitDE1545AppealInitiateForm() {
    this.bifSubmitted = true;
    if (this.de1545AppealInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de1545AppealFormInit()
  }



}
