import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '../../../../services/app.service'
import { ClaimsService  } from '../../../../services/claims.service'

@Component({
  selector: 'app-de1101-response-form',
  templateUrl: './de1101-response-form.component.html',
  styleUrls: ['./de1101-response-form.component.scss']
})
export class De1101ResponseFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public de1101ResponseInitiateForm: FormGroup;
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
  de1101ResponseFormInit() {
    this.de1101ResponseInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      lausdMailDate          : ['', Validators.required],
      ClaimDateByb           : ['', Validators.required],
      dateOfClaim            : ['', Validators.required],
      dueDate                : ['', Validators.required],
      claimantName           : ['', Validators.required],
      claimantSSN            : ['', Validators.required],
      issuesList             : ['', Validators.required],
      lausdResponse          : ['', Validators.required],
      printName              : ['', Validators.required],
      phoneNo                : ['', Validators.required],
      signature              : ['', Validators.required],
      title                  : ['', Validators.required],
      date                   : ['', Validators.required],
      attachedDocument       : ['', Validators.required],
    });
  }

  get bfi() { return this.de1101ResponseInitiateForm.controls; }

  submitDE1101ResponseInitiateForm() {
    this.bifSubmitted = true;
    if (this.de1101ResponseInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de1101ResponseFormInit()
  }


}
