import { Component, OnInit, ViewChild} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute} from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employee-data',
  templateUrl: './employee-data.component.html',
  styleUrls: ['./employee-data.component.scss']
})
export class EmployeeDataComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;
  
  public employeeDetails : any = [];
  public employeeId:number;


  // form setion var 
  public empDataForm: FormGroup;
  public formSubmitted: boolean = false;


  constructor(
    public aps: AppService,
    public cs:  ClaimsService,
    private fb: FormBuilder,
    private cas: ClaimsApiService,
    private route: ActivatedRoute,
    private tort: ToastrService
  ){

  }

  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }

  // form section 
  employeeFormInit() {
    this.empDataForm = this.fb.group({
      id                   : [''                                                      ]  ,
      claimId              : [''                                                      ]  ,
      date                 : ['', Validators.required                                 ]  ,
      bybClaimDate         : ['', Validators.required                                 ]  ,
      claimantName         : ['', Validators.required                                 ]  ,
      socialSecurityNumber : ['', [Validators.required,Validators.pattern("^[0-9]*$")]]  ,
      userCompletedBy      : ['', Validators.required                                 ]  ,
      userCompletedDate    : ['', Validators.required                                 ]  ,
      userTitle            : ['', Validators.required                                 ]  ,
      userTelephoneNumber  : ['', [Validators.required,Validators.pattern("^[0-9]*$")]]  ,  
    });
  }

  get fc() { return this.empDataForm.controls; }
  get fv() { return this.empDataForm.value; }
  get fvalid() { return this.empDataForm.valid; }

  submitEmpDataForm() {
    this.formSubmitted = true;
    if (this.empDataForm.invalid) { return; }
  }


  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.date.setValue(this.aps.formatDate(data.date))
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.userCompletedBy.setValue(data.userCompletedBy)
    this.fc.userCompletedDate.setValue(this.aps.formatDate(data.userCompletedDate))
    this.fc.userTitle.setValue(data.userTitle)
    this.fc.userTelephoneNumber.setValue(data.userTelephoneNumber)
  }

  getFormDetails() {
    // this.employeeId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.employeeId = 1
    this.cas.getRequestForEmpData(this.employeeId)
      .subscribe(
        (res) => {
          this.employeeDetails = res;
          this.setFormvalues(this.employeeDetails)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }


  saveForm() {

    if (this.fvalid) {

      this.fv.date  = this.aps.formatDate(this.fv.date)

      this.cas.updateRequestForEmpData(this.fv)
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
    this.employeeFormInit()
    this.getFormDetails()
  }


}
