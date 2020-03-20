import { BrowserModule } from '@angular/platform-browser';
import { NgModule , APP_INITIALIZER} from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http'; 
import { HashLocationStrategy, LocationStrategy } from '@angular/common';

import { AdalService, AdalGuard, AdalInterceptor } from 'adal-angular4';
import { HTTP_INTERCEPTORS } from '@angular/common/http';


// services 
import { AdInterceptorService } from './adalAuth/ad-interceptor.service'
import { ConfigsLoaderService } from './configs-loader.service';

// app modules 
import { AppRoutingModule } from './@modules/app-routing.module';
import { SidebarModule } from './@modules/sidebar.module'


// components 
import { AppComponent } from './app.component';
import { BtcomponentComponent } from './btcomponent/btcomponent.component';
import { HeaderComponent } from './components/header/header.component';


@NgModule({
  declarations: [
    AppComponent,
    BtcomponentComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    SidebarModule,
    HttpClientModule
  ],
  providers: [
    { 
      provide: LocationStrategy, 
      useClass: HashLocationStrategy 
    },
    {
      provide: APP_INITIALIZER,
      useFactory: appInitializerFactory,
      deps: [ConfigsLoaderService],
      multi: true
    },
    AdalService, AdalGuard, {
      provide: HTTP_INTERCEPTORS, 
      useClass: AdInterceptorService, 
      multi: true 
    }
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }


export function appInitializerFactory(configsLoaderService: ConfigsLoaderService) {
  return () => configsLoaderService.loadConfigs();
}