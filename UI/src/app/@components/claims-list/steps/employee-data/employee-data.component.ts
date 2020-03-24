import { Component, OnInit, ViewChild} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'

@Component({
  selector: 'app-employee-data',
  templateUrl: './employee-data.component.html',
  styleUrls: ['./employee-data.component.scss']
})
export class EmployeeDataComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  // form setion var 
  public employeeInitiateForm: FormGroup;
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
  employeeFormInit() {
    this.employeeInitiateForm = this.fb.group({
      date                 : ['', Validators.required],
      byb                  : ['', Validators.required],
      claimantName         : ['', Validators.required],
      claimantSSN          : ['', Validators.required],
      completedBy          : ['', Validators.required],
      dateCompleted        : ['', Validators.required],
      title                : ['', Validators.required], 
      telephoneNo          : ['', Validators.required],   
    });
  }

  get fc() { return this.employeeInitiateForm.controls; }

  submitEmployeeInitiateForm() {
    this.formSubmitted = true;
    if (this.employeeInitiateForm.invalid) { return; }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.employeeFormInit()
  }


}
