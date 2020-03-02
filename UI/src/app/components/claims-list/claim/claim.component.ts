import { Component, OnInit , ViewChild , TemplateRef , ElementRef} from '@angular/core';

import { TabsetComponent } from 'ngx-bootstrap';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';



@Component({
  selector: 'app-claim',
  templateUrl: './claim.component.html',
  styleUrls: ['./claim.component.scss']
})
export class ClaimComponent implements OnInit {

  @ViewChild('staticTabs', { static: false }) staticTabs: TabsetComponent;

  @ViewChild('uploadtext', { static: true }) uploadtext: ElementRef;
  
  tabIncDec   : number = 0 ;
  tabincLimit : number = 0;
  
  modalRef: BsModalRef;

  constructor(private modalService: BsModalService) {


  }


  selectTab(tabId: number) {
    this.staticTabs.tabs[tabId].active = true;
  }

  increaseTabCount()  {
    if( this.tabIncDec < this.tabincLimit-1) {
      this.tabIncDec++;
      this.selectTab(this.tabIncDec)
    }
  }
  
  descreaseTabCount() {
    if( this.tabIncDec >0) { 
      this.tabIncDec--;
      this.selectTab(this.tabIncDec)
    }
  }
 
  openModal(uploadAttachment: TemplateRef<any>) {
    this.modalRef = this.modalService.show(uploadAttachment);
  }

  confirm(): void {
    this.modalRef.hide();
  }
 
  decline(): void {
    this.modalRef.hide();
  }

  setUploadText(ev) {
    ev.target.parentElement.querySelector('.cc-fuf-text').innerHTML =  ev.target.files[0].name;
  }

  ngOnInit() {

    this.tabincLimit = 2;
  }

}
