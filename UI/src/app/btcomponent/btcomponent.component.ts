import { Component, OnInit } from '@angular/core';


import { TemplateRef } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';


@Component({
  selector: 'app-btcomponent',
  templateUrl: './btcomponent.component.html',
  styleUrls: ['./btcomponent.component.scss']
})
export class BtcomponentComponent implements OnInit {


  modalRef: BsModalRef;

  itemStringsLeft = [
    'Windstorm',
    'Bombasto',
    'Magneta',
    'Tornado'
  ];
 
  itemStringsRight = ['Mr. O', 'Tomato'];

  mytime: Date = new Date();

  constructor(private modalService: BsModalService) { }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
    console.log(template)
  }


  ngOnInit() {
  }

}
