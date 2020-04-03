import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { AppService } from 'app/@services/app.service'
import { ClaimsService } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-employee-data',
  templateUrl: './employee-data.component.html',
  styleUrls: ['./employee-data.component.scss']
})
export class EmployeeDataComponent implements OnInit {

  @Input() uavalue: any;

  // form setion var 
  public empDataForm: FormGroup;
  public formSubmitted: boolean = false;

  public employeeDetails: any = [];
  public employeeId: number;

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) {

  }

  // form section 
  employeeFormInit() {
    this.empDataForm = this.fb.group({
      id                  : ['', Validators.required                                  ],
      claimId             : ['', Validators.required                                  ],
      date                : ['', Validators.required                                  ],
      bybClaimDate        : ['', Validators.required                                  ],
      claimantName        : ['', Validators.required                                  ],
      socialSecurityNumber: ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      userCompletedBy     : ['', Validators.required                                  ],
      userCompletedDate   : ['', Validators.required                                  ],
      userTitle           : ['', Validators.required                                  ],
      userTelephoneNumber : ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
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
      .subscribe((res) => {
        if(res != null) {
          this.employeeDetails = res;
          this.setFormvalues(this.employeeDetails)
        }
      })
  }

  saveForm() {

    if (this.fvalid) {

      this.fv.date = this.aps.formatDate(this.fv.date)

      this.cas.updateRequestForEmpData(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }
    
  }

  ngOnInit() {
    this.employeeFormInit()
    this.getFormDetails()
  }

}
