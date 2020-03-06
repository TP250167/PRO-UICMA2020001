import { Component, OnInit,ElementRef,ViewChild,TemplateRef} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '../../../../services/app.service'
import { ClaimsService } from '../../../../services/claims.service'

@Component({
  selector: 'app-notice-of-wages',
  templateUrl: './notice-of-wages.component.html',
  styleUrls: ['./notice-of-wages.component.scss']
})
export class NoticeOfWagesComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  // form setion var 
  noticeOfWagesInitiateForm: FormGroup;
  nwifSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
  ) {

  }


  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  NoticeOfWagesFormInit() {
    this.noticeOfWagesInitiateForm = this.fb.group({
      claimantName             : ['', Validators.required],
      ssn                      : ['', Validators.required],
      totalWages               : ['', Validators.required],
      benefitsCharge           : ['', Validators.required],
    });
  }

  get nwfi() { return this.noticeOfWagesInitiateForm.controls; }

  submitNoticeOfWagesInitiateForm() {
    this.nwifSubmitted = true;
    if (this.noticeOfWagesInitiateForm.invalid) { return; }
    console.log(this.noticeOfWagesInitiateForm.value)
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.NoticeOfWagesFormInit()
  }

}
