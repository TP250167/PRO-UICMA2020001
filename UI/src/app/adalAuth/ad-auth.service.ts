import { Injectable } from '@angular/core';

import { AdalService } from 'adal-angular4';

import { ConfigsLoaderService, Configs } from '../configs-loader.service';

@Injectable({
  providedIn: 'root'
})

export class AdAuthService {

  public userInfo : any ;

  public adsf :  any; 

  constructor(
    private adalService: AdalService,
    private cls: ConfigsLoaderService
  ) { 
    this.userInfo = this.adalService.userInfo;
    this.adsf =  this.adalService ;
  }

  adInit() {
    this.adalService.init(this.cls.Config.adalConfig);
  }

  adCb() { 
    this.adalService.handleWindowCallback();
  }

  login() {
    this.adalService.login();
  }

  logout() {
    this.adalService.logOut();
  }

  authenticated(): boolean {
    return this.adalService.userInfo.authenticated;
  }


}
