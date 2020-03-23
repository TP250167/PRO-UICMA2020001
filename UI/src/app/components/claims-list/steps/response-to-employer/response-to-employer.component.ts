import { Component, OnInit,ElementRef,ViewChild,TemplateRef} from '@angular/core';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '@services/app.service'
import { ClaimsService } from '@services/claims.service'

@Component({
  selector: 'app-response-to-employer',
  templateUrl: './response-to-employer.component.html',
  styleUrls: ['./response-to-employer.component.scss']
})
export class ResponseToEmployerComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;


  // form setion var 
  responseInitiateForm: FormGroup;
  rifSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
  ) {

  }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  ResponseFormInit() {
    this.responseInitiateForm = this.fb.group({
      claimantName             : ['', Validators.required],
      ssn                      : ['', Validators.required],
      dateMailed               : ['', Validators.required],
      byb                      : ['', Validators.required],
    });
  }

  get rfi() { return this.responseInitiateForm.controls; }

  submitResponseInitiateForm() {
    this.rifSubmitted = true;
    if (this.responseInitiateForm.invalid) { return; }
    console.log(this.responseInitiateForm.value)
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.ResponseFormInit()
  }
}
