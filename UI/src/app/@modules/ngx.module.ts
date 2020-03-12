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
import { ToastrModule } from 'ngx-toastr';

import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { DatePipe } from '@angular/common';


import { FormInputFocusDirective } from '../@directives/form-input-focus.directive';
import { CustomUploadDirective } from '../@directives/custom-upload.directive';


@NgModule({
  declarations: [
    FormInputFocusDirective,
    CustomUploadDirective
  ],
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
    ToastrModule.forRoot(),
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [DatePipe],
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
    ToastrModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    FormInputFocusDirective,
    CustomUploadDirective
  ]
})
export class NgxModule { }
