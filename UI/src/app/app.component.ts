import { Component } from '@angular/core';


import { AdAuthService } from './adalAuth/ad-auth.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  constructor(private ads: AdAuthService) {
    this.ads.adInit()
    this.ads.adCb()
  }

  appAuth() {
    if (!(this.ads.userInfo.authenticated && this.ads != null)) {
      this.ads.login();
    } 
  }

  appClosingPrevent() {
    window.addEventListener('beforeunload', function (e) { 
			e.preventDefault(); 
			e.returnValue = ''; 
		}); 
  }

  ngOnInit() {
    this.appAuth();
    // this.appClosingPrevent();
  }


}
