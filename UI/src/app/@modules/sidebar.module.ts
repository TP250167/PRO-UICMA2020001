import { NgModule } from '@angular/core';
import { NgxModule } from 'app/@modules/ngx.module'


import { SidebarComponent } from 'app/@components/sidebar/sidebar.component'
import { SidebarProcessStepsComponent } from 'app/@components/sidebar-process-steps/sidebar-process-steps.component'

@NgModule({
  declarations: [
    SidebarComponent,
    SidebarProcessStepsComponent
  ],
  imports: [
    NgxModule
  ],
  exports: [
    SidebarComponent,
    SidebarProcessStepsComponent
  ]
})
export class SidebarModule { }
