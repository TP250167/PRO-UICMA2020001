import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccordionModule } from 'ngx-bootstrap/accordion';
import { AlertModule } from 'ngx-bootstrap/alert';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
import { PopoverModule } from 'ngx-bootstrap/popover';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { TimepickerModule } from 'ngx-bootstrap/timepicker';
import { SortableModule } from 'ngx-bootstrap/sortable';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    AccordionModule.forRoot(),
    AlertModule.forRoot(),
    ButtonsModule.forRoot(),
    BsDatepickerModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    PopoverModule.forRoot(),
    TabsModule.forRoot(),
    TimepickerModule.forRoot(),
    SortableModule.forRoot(),
  ],
  exports: [
    AccordionModule,
    AlertModule,
    ButtonsModule,
    BsDatepickerModule,
    BsDropdownModule,
    ModalModule,
    PopoverModule,
    TabsModule,
    TimepickerModule,
    SortableModule,
    CommonModule
  ]
})
export class NgxModule { }
