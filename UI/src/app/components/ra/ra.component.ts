import { Component, OnInit,ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TabsetComponent } from 'ngx-bootstrap';

import { AppService } from '../..../../../services/app.service'
import { ClaimsService } from '../..../../../services/claims.service'

@Component({
  selector: 'app-ra',
  templateUrl: './ra.component.html',
  styleUrls: ['./ra.component.scss']
})
export class RaComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;


    // form setion var 
    public batchInitiateForm: FormGroup;
    public bifSubmitted: boolean = false;
  
    //multi select 
    // disabled = false;
    //     ShowFilter = false;
    //     limitSelection = false;
    //     cities: Array = [];
    //     selectedItems: Array = [];
    //     dropdownSettings: any = {};

  
    constructor(
      public aps: AppService,
      public cs:  ClaimsService,
      private fb: FormBuilder,
      private router: Router,
    ){
  
    }
  
  
    itc() { this.cs.increaseTabCount(this.staticTabs) ; } 
    dtc() { this.cs.descreaseTabCount(this.staticTabs); }


//   selectdrop(){
//     this.cities = [
//       { item_id: 1, item_text: 'New Delhi' },
//       { item_id: 2, item_text: 'Mumbai' },
//       { item_id: 3, item_text: 'Bangalore' },
//       { item_id: 4, item_text: 'Pune' },
//       { item_id: 5, item_text: 'Chennai' },
//       { item_id: 6, item_text: 'Navsari' }
//   ];
//   this.selectedItems = [{ item_id: 4, item_text: 'Pune' }, { item_id: 6, item_text: 'Navsari' }];
//   this.dropdownSettings = {
//       singleSelection: false,
//       idField: 'item_id',
//       textField: 'item_text',
//       selectAllText: 'Select All',
//       unSelectAllText: 'UnSelect All',
//       itemsShowLimit: 3,
//       allowSearchFilter: this.ShowFilter
//   };
//   this.myForm = this.fb.group({
//       recipientSet: [this.selectedItems]
//   });
// }

// onItemSelect(item: any) {
//   console.log('onItemSelect', item);
// }
// onSelectAll(items: any) {
//   console.log('onSelectAll', items);
// }
// toogleShowFilter() {
//   this.ShowFilter = !this.ShowFilter;
//   this.dropdownSettings = Object.assign({}, this.dropdownSettings, { allowSearchFilter: this.ShowFilter });
// }

// handleLimitSelection() {
//   if (this.limitSelection) {
//       this.dropdownSettings = Object.assign({}, this.dropdownSettings, { limitSelection: 2 });
//   } else {
//       this.dropdownSettings = Object.assign({}, this.dropdownSettings, { limitSelection: null });
//   }
// }
    // form section 
    batchFormInit() {
      this.batchInitiateForm = this.fb.group({
        batchName        : ['', Validators.required],
        recipientSet     : ['', Validators.required],
        scheduleDate     : ['', Validators.required],
      });
    }
  
    get bfi() { return this.batchInitiateForm.controls; }
  
    submitBatchInitiateForm() {
      this.bifSubmitted = true;
      if (this.batchInitiateForm.invalid) { return; }
    }

    check(){
      console.log(this.batchInitiateForm.value)
    }
    
    gotoNotificationLogs(){
      this.router.navigateByUrl(`/ra/notification-log`);
    }
  
    ngOnInit() {
      this.cs.tabincLimit = 2;
      this.batchFormInit()
    }

}
