import { Component, OnInit, ViewChild } from '@angular/core';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '../../../../services/app.service'
import { ClaimsService } from '../../../../services/claims.service'

@Component({
  selector: 'app-acknowledgement',
  templateUrl: './acknowledgement.component.html',
  styleUrls: ['./acknowledgement.component.scss']
})
export class AcknowledgementComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  public acknowledgementForm: FormGroup;
  public ackSubmitted: boolean = false;

  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
  ) { }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  acknowledgementFormInit() {
    this.acknowledgementForm = this.fb.group({
      claimName         : ['', Validators.required],
      abCaseNumber      : ['', Validators.required],
      aljDecisionNumber : ['', Validators.required],
      appellant         : ['', Validators.required],
      mailDate          : ['', Validators.required],
    });
  }

  get acki() { return this.acknowledgementForm.controls; }

  submitAcknowledgementForm() {
    this.ackSubmitted = true;
    if (this.acknowledgementForm.invalid) { return; }
    console.log(this.acknowledgementForm.value)
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.acknowledgementFormInit()
  }

}
