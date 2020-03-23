import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService } from '@services/claims.service'

@Component({
  selector: 'app-appeal-form',
  templateUrl: './appeal-form.component.html',
  styleUrls: ['./appeal-form.component.scss']
})
export class AppealFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  appealInitiateForm: FormGroup;
  aifSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
  ) {

  }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  appealFormInit() {
    this.appealInitiateForm = this.fb.group({
      claimantName           : ['', Validators.required],
      ssn                    : ['', Validators.required],
      needTranslator         : ['', Validators.required],
      translatorLanguage     : ['', Validators.required],
      appellantAddress       : ['', Validators.required],
      appellantTelephoneNo   : ['', Validators.required],
      appellantFaxNo         : ['', Validators.required],
      appellantcellphoneNo   : ['', Validators.required],
      appellanteMailAddress  : ['', Validators.required],
      authorizeEmail         : ['', Validators.required],
      authorizeVm            : ['', Validators.required],
      employerAccountNo      : ['', Validators.required],
      agentName              : ['', Validators.required],
      agentAddress           : ['', Validators.required],
      appellantNoticeDate    : ['', Validators.required],
      appellantComments      : ['', Validators.required],
      SignatureAppellant     : ['', Validators.required],
      formDate               : ['', Validators.required],
    });
  }

  get afi() { return this.appealInitiateForm.controls; }

  submitAppealInitiateForm() {
    this.aifSubmitted = true;
    if (this.appealInitiateForm.invalid) { return; }
    console.log(this.appealInitiateForm.value)
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.appealFormInit()
  }

}
