import { Injectable , TemplateRef } from '@angular/core';
import { DatePipe } from '@angular/common';

import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  modalRef: BsModalRef;

  ngxcalConfig:any  = { containerClass: 'theme-blue', showWeekNumbers:false , dateInputFormat: 'MM-DD-YYYY'} 
  ngxcalyConfig:any = { containerClass: 'theme-blue', showWeekNumbers:false , dateInputFormat: 'YYYY'} 

  toastTime =  3000;

  constructor(
    private modalService: BsModalService,
    private datePipe: DatePipe,
    private tort: ToastrService,
  ) { }


  onOpenYearCalendar(container) {
    container.monthSelectHandler = (event: any): void => {
      container._store.dispatch(container._actions.select(event.date));
    };     
    container.setViewMode('year');
  }


  openModal(modalpopup: TemplateRef<any>) {
    this.modalRef = this.modalService.show(modalpopup);
  }

  closeModel(): void {
    this.modalRef.hide();
  }

  formatDate(val){
   return this.datePipe.transform(val,'MM/dd/yyyy');
  }

  toastSaved() {
    return this.tort.success('Data successfully Saved', 'Saved',  { timeOut: this.toastTime });
  }

  toastUpdated() {
    return this.tort.success('Data successfully updated', 'Updated', { timeOut: this.toastTime});
  }
  toastRemoved() {
    return this.tort.error('Data successfully deleted', 'Deleted', { timeOut: this.toastTime});
  }


  filterAo(aArr,fArr) {
    var filtered = aArr.filter(function(i){
      return fArr.some(function(j){
          return !Object.keys(j).some(function(prop){
              return i[prop] != j[prop];
          });
      });
    });
  
  return filtered;
  }

}
