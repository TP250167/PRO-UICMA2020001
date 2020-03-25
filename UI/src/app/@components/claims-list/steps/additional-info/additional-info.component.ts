import { Component, OnInit, ViewChild} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute} from '@angular/router';

import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from 'app/@services/app.service'
import { ClaimsService  } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

import { ToastrService } from 'ngx-toastr'

@Component({
  selector: 'app-additional-info',
  templateUrl: './additional-info.component.html',
  styleUrls: ['./additional-info.component.scss']
})
export class AdditionalInfoComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  public additionalInfoDetail :any = [];
  public additionalId:number;
  
  // form setion var 
  public aiForm: FormGroup;
  public formSubmitted: boolean = false;


  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    public  cas  : ClaimsApiService,
    public  route: ActivatedRoute  ,
    public  tort : ToastrService   ,
  ){

  }


  itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
  dtc() { this.cs.descreaseTabCount(this.staticTabs); }


  // form section 
  additionalFormInit() {
    this.aiForm = this.fb.group({
      id                   : [''                     ],
      claimId              : [''                     ],
      mailDate             : ['', Validators.required],
      claimantName         : ['', Validators.required],
      socialSecurityNumber : ['', Validators.required],
      claimEffectiveDate   : ['', Validators.required],
      controlNumber        : ['', Validators.required],  
    });
  }

  get fc() { return this.aiForm.controls; }
  get fv() { return this.aiForm.value; }
  get fvalid() { return this.aiForm.valid; }

  submitAiForm() {
    this.formSubmitted = true;
    if (this.aiForm.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.mailDate.setValue(this.aps.formatDate(data.mailDate)) 
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.claimEffectiveDate.setValue(this.aps.formatDate(data.claimEffectiveDate))
    this.fc.controlNumber.setValue(data.controlNumber)
  }

  getFormDetails() {
    // this.additionalId = parseInt(this.route.snapshot.paramMap.get('id')) 
    this.additionalId = 1 
    this.cas.getAdditionalInfo(this.additionalId)
      .subscribe(
        (res) => {
          this.additionalInfoDetail = res;
          this.setFormvalues(this.additionalInfoDetail)
        },
        (error) => {
          console.log('error caught in get claim details', error)
        }
      )
  }


  saveForm() {

    if (this.fvalid) {

      this.fv.mailDate  = this.aps.formatDate(this.fv.mailDate)

      this.cas.updateAdditionalInfo(this.fv)
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
    this.additionalFormInit()
    this.getFormDetails()
  }



}
