import { Injectable , ViewChild } from '@angular/core';

@Injectable({
  providedIn: 'root'
})


export class ClaimsService {

  public formStepPosition : string = 'claim' ;

  public tabIncDec   : number = 0;
  public tabincLimit : number = 0;


  constructor() { }


  // document tabsection 

  selectTab(tab,tabId: number) {
    tab.tabs[tabId].active = true;
  }

  increaseTabCount(tab) {
    if (this.tabIncDec < this.tabincLimit - 1) {
      this.tabIncDec++;
      this.selectTab(tab,this.tabIncDec)
    }
  }

  descreaseTabCount(tab) {
    if (this.tabIncDec > 0) {
      this.tabIncDec--;
      this.selectTab(tab,this.tabIncDec)
    }
  }
  
  gotoStep(step) {
    this.formStepPosition =  step ;
  }


}
