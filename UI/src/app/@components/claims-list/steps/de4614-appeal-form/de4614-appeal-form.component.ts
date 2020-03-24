import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-de4614-appeal-form',
  templateUrl: './de4614-appeal-form.component.html',
  styleUrls: ['./de4614-appeal-form.component.scss']
})
export class De4614AppealFormComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  

  public claimId: number ;
  public appealFormDetails : any = []

  // form setion var 
  public de4614AppealInitiateForm: FormGroup;
  public formSubmitted: boolean = false;

  

  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private tort: ToastrService,
    private route: ActivatedRoute,
    private datePipe: DatePipe
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  de4614AppealFormInit() {
    this.de4614AppealInitiateForm = this.fb.group({
      officeAddress          : ['', Validators.required],
      lausdFaxDate           : ['', Validators.required],
      lausdAcNo              : ['', Validators.required],
      ClaimDateByb           : ['', Validators.required],
      de4614Date             : ['', Validators.required],
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

  get fc() { return this.de4614AppealInitiateForm.controls; }

  submitDE4614AppealInitiateForm() {
    this.formSubmitted = true;
    if (this.de4614AppealInitiateForm.invalid) { return; }
  }


  appealFormSetValues(data) {

  }

  getAppealFormDetails() {
    // this.claimId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.claimId = 2 
    this.cas.getClaim(this.claimId)
      .subscribe(
        (res) => {
          this.appealFormDetails = res;
          this.appealFormSetValues(this.appealFormDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }

  saveAppealForm() {
    if (this.de4614AppealInitiateForm.valid) { 
      this.cas.updateClaim(this.de4614AppealInitiateForm.value)
      .subscribe(
        (res) => {
          this.tort.success('claim', 'claim successfully updated', { timeOut: 5000, });
          console.log(res)
        },
        (error) => {
          console.log('error caught in batch detail update', error)
        }
      )
    }
  }

  ngOnInit() {
    this.cs.tabincLimit = 2;
    this.de4614AppealFormInit()
  }


}
