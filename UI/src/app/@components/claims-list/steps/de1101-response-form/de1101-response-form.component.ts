import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';


import { AppService       } from 'app/@services/app.service'
import { ClaimsService    } from 'app/@services/claims.service'
import { ClaimsApiService } from 'app/@services/claims-api.service'

@Component({
  selector: 'app-de1101-response-form',
  templateUrl: './de1101-response-form.component.html',
  styleUrls: ['./de1101-response-form.component.scss']
})
export class De1101ResponseFormComponent implements OnInit {

  // form setion var 
  public De1101Form: FormGroup;
  public formSubmitted: boolean = false;

  public formId: number;
  public responseFormDetails: any = []

  public dropdownList: any = [];
  public selectedItems: any = [];
  public dropdownSettings: any = {};

  public packageDocumentList = [
    {"id":1,"docName":'RA Letter' , "docNumber":1234},
    {"id":2,"docName":'Time/Wage Report', "docNumber":1452},
    {"id":3,"docName":'Summary of Work', "docNumber":2548},
    {"id":4,"docName":'Protest Page', "docNumber":3658},
    {"id":5,"docName":'Claimant Information Report', "docNumber":7858},
    {"id":6,"docName":'Statement of Charges', "docNumber":1245},
    {"id":7,"docName":'Warning Letters', "docNumber":3541},
    {"id":8,"docName":'EE Contract', "docNumber":7548},
    {"id":9,"docName":'Offer Letter', "docNumber":8252},
    {"id":10,"docName":'dismissal charges', "docNumber":4252},
  ]

  public showPdList : any = []

  constructor(
    public  aps  : AppService      ,
    public  cs   : ClaimsService   ,
    private fb   : FormBuilder     ,
    private cas  : ClaimsApiService,
    private route: ActivatedRoute  ,
  ) {

  }

  // form section 
  de1101ResponseFormInit() {
    this.De1101Form = this.fb.group({
      id                   : ['', Validators.required],
      claimId              : ['', Validators.required],
      claimantName         : ['', Validators.required],
      socialSecurityNumber : ['', Validators.required],
      AccountNumber        : ['', Validators.required],
      phoneNumber          : ['', Validators.required],
      printName            : ['', Validators.required],
      title                : ['', Validators.required],
      signature            : ['', Validators.required],
      eddFieldOfficeAddress: ['', Validators.required],
      lausdMailDate        : ['', Validators.required],
      bybClaimDate         : ['', Validators.required],
      effectiveDateOfClaim : ['', Validators.required],
      dueDate              : ['', Validators.required],
      lausdResponse        : ['', Validators.required],
      eddMailDate          : ['', Validators.required],
      issuesList           : ['', Validators.required],
      date                 : ['', Validators.required],
      attachedDocument     : ['', Validators.required],
      claimResNotes        : ['', Validators.required],
    });
  }

  get fc() { return this.De1101Form.controls; }
  get fv() { return this.De1101Form.value; }
  get fvalid() { return this.De1101Form.valid; }

  submitDe1101Form() {
    this.formSubmitted = true;
    if (this.De1101Form.invalid) { return; }
  }

  setFormvalues(data) {
    this.fc.id.setValue(data.id)
    this.fc.claimId.setValue(data.claimId)
    this.fc.claimantName.setValue(data.claimantName)
    this.fc.socialSecurityNumber.setValue(data.socialSecurityNumber)
    this.fc.AccountNumber.setValue(data.AccountNumber)
    this.fc.phoneNumber.setValue(data.phoneNumber)
    this.fc.printName.setValue(data.printName)
    this.fc.title.setValue(data.title)
    this.fc.signature.setValue(data.signature)
    this.fc.eddFieldOfficeAddress.setValue(data.address)
    this.fc.lausdMailDate.setValue(this.aps.formatDate(data.lausdMailDate))
    this.fc.bybClaimDate.setValue(this.aps.formatDate(data.bybClaimDate))
    this.fc.effectiveDateOfClaim.setValue(this.aps.formatDate(data.effectiveDateOfClaim))
    this.fc.dueDate.setValue(this.aps.formatDate(data.dueDate))
    this.fc.lausdResponse.setValue(data.lausdResponse)
    this.fc.eddMailDate.setValue(data.eddMailDate)
    this.fc.issuesList.setValue(data.issuesList)
    this.fc.date.setValue(this.aps.formatDate(data.date))
    this.fc.attachedDocument.setValue(data.attachedDocument)
    this.fc.claimResNotes.setValue(data.claimResNotes)
  }

  getFormDetails() {
    this.formId = parseInt(this.route.snapshot.paramMap.get('id'))
    // this.formId = 2;
    this.cas.getClaimResponse(this.formId)
      .subscribe((res) => {
        if(res != null) {
          this.responseFormDetails = res;
          this.setFormvalues(this.responseFormDetails);
        }
      })
  }

  saveForm() {
    
    if (this.fvalid) {
      
      this.fv.lausdMailDate        = this.aps.formatDate(this.fv.lausdMailDate        );
      this.fv.bybClaimDate         = this.aps.formatDate(this.fv.bybClaimDate         );
      this.fv.effectiveDateOfClaim = this.aps.formatDate(this.fv.effectiveDateOfClaim );
      this.fv.dueDate              = this.aps.formatDate(this.fv.dueDate              );
      this.fv.date                 = this.aps.formatDate(this.fv.date                 );

      this.cas.updateClaimResponse(this.fv)
        .subscribe((res) => {
          (this.fv.id == 0) ? this.aps.toastSaved() : this.aps.toastUpdated();
        })
    }

  }

  multiselectConfig() {
    
    this.dropdownSettings = {
      singleSelection  : false,
      idField          : 'id',
      textField        : 'docName',
      selectAllText    : 'Select All',
      unSelectAllText  : 'UnSelect All',
      itemsShowLimit   : 3,
      allowSearchFilter: true
    };

    this.dropdownList  = this.packageDocumentList ;

    this.selectedItems = [
      {"id":1,"docName":'RA Letter'},
      {"id":2,"docName":'Time/Wage Report'},
      {"id":3,"docName":'Summary of Work'},
      {"id":4,"docName":'Protest Page'},
      {"id":5,"docName":'Claimant Information Report'},
    ]

    this.showPdList = this.aps.filterAo(this.packageDocumentList,this.selectedItems)
  }

  filterPackageTable() {
    this.showPdList = this.aps.filterAo(this.packageDocumentList,this.selectedItems)
    this.aps.closeModel()
  }


  ngOnInit() {
    this.de1101ResponseFormInit();
    this.getFormDetails();
    this.multiselectConfig();
  }


}
