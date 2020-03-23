import { Component, OnInit, TemplateRef ,ElementRef ,ViewChild} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'


@Component({
  selector: 'app-notice-of-determination',
  templateUrl: './notice-of-determination.component.html',
  styleUrls: ['./notice-of-determination.component.scss']
})
export class NoticeOfDeterminationComponent implements OnInit {
 
  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

   // form section var 
   noticeDeterminationForm: FormGroup;
   nifSubmitted: boolean = false;

   constructor(
    public aps: AppService,
    public cs: ClaimsService,
    private fb: FormBuilder,
  ) { }

  itc() { this.cs.increaseTabCount(this.staticTabs); }
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  //form section
  noticeDeterminationFormInit() {
    this.noticeDeterminationForm = this.fb.group({
      dateMailed          : ['', Validators.required],
      byb                 : ['', Validators.required],
      ssn                 : ['', Validators.required],
      fieldOffice         : ['', Validators.required],
      decision            : ['', Validators.required],
    });
  }

  get nfi() { return this.noticeDeterminationForm.controls; }

  submitNoticeDeterminationForm() {
    this.nifSubmitted = true;
    if (this.noticeDeterminationForm.invalid) { return; }
    console.log(this.noticeDeterminationForm.value)
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.noticeDeterminationFormInit()
  }

}
