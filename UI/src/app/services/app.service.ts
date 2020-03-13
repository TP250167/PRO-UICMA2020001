import { Injectable , TemplateRef } from '@angular/core';

import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';


@Injectable({
  providedIn: 'root'
})
export class AppService {

  modalRef: BsModalRef;

  constructor(
    private modalService: BsModalService,
  ) { }


  openModal(modalpopup: TemplateRef<any>) {
    this.modalRef = this.modalService.show(modalpopup);
  }

  closeModel(): void {
    this.modalRef.hide();
  }



}
