import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService } from '@services/claims.service'


@Component({
  selector: 'app-alj-decision',
  templateUrl: './alj-decision.component.html',
  styleUrls: ['./alj-decision.component.scss']
})
export class AljDecisionComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public aljDecistionForm: FormGroup;
  public aljSubmitted: boolean = false;

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
  ) { }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  aljFormInit() {
    this.aljDecistionForm = this.fb.group({
      claimName       : ['', Validators.required],
      empInfo         : ['', Validators.required],
      aljName         : ['', Validators.required],
      mailDate        : ['', Validators.required],
      caseNumber      : ['', Validators.required],
      fcaseNumber     : ['', Validators.required],
      reopen          : ['', Validators.required],
      hearingDate     : ['', Validators.required],
      hearingPlace    : ['', Validators.required],
      partiesAppering : ['', Validators.required],
      decision        : ['', Validators.required],
    });
  }

  get alji() { return this.aljDecistionForm.controls; }

  submitAljForm() {
    this.aljSubmitted = true;
    if (this.aljDecistionForm.invalid) { return; }
    console.log(this.aljDecistionForm.value)
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.aljFormInit()
  }

}
