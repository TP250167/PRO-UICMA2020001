import { Component, OnInit, ViewChild} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'

@Component({
  selector: 'app-additional-info',
  templateUrl: './additional-info.component.html',
  styleUrls: ['./additional-info.component.scss']
})
export class AdditionalInfoComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public additionalInitiateForm: FormGroup;
  public formSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  additionalFormInit() {
    this.additionalInitiateForm = this.fb.group({
      mailDate             : ['', Validators.required],
      claimantName         : ['', Validators.required],
      claimantSSN          : ['', Validators.required],
      ced                  : ['', Validators.required],
      controlNo            : ['', Validators.required],  
    });
  }

  get fc() { return this.additionalInitiateForm.controls; }

  submitAdditionalInitiateForm() {
    this.formSubmitted = true;
    if (this.additionalInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.additionalFormInit()
  }



}
