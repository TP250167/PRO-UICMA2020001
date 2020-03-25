import { Injectable , TemplateRef } from '@angular/core';

import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

import { DatePipe } from '@angular/common';


@Injectable({
  providedIn: 'root'
})
export class AppService {

  modalRef: BsModalRef;

  constructor(
    private modalService: BsModalService,
    private datePipe: DatePipe
  ) { }


  openModal(modalpopup: TemplateRef<any>) {
    this.modalRef = this.modalService.show(modalpopup);
  }

  closeModel(): void {
    this.modalRef.hide();
  }

  formatDate(val){
   return this.datePipe.transform(val,'MM/dd/yyyy')
  }


}
