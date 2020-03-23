import { NgModule } from '@angular/core';
import { NgxModule } from '@modules/ngx.module'


import { SidebarComponent } from '@components/sidebar/sidebar.component'
import { SidebarProcessStepsComponent } from '@components/sidebar-process-steps/sidebar-process-steps.component'

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
