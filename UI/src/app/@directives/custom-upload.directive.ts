import { Directive , HostListener, ElementRef } from '@angular/core';

@Directive({
  selector: '[appCustomUpload]'
})
export class CustomUploadDirective {

  constructor(private el: ElementRef) { }

  @HostListener('change',['$event']) ngOnChanges(ev) {
     ev.target.parentElement.querySelector('.cc-fuf-text') .innerHTML = ev.target.files[0].name;
  }

}
