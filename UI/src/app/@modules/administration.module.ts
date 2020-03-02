import { NgModule } from '@angular/core';
import { NgxModule } from '../@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'

import { AdministrationComponent } from '../components/administration/administration.component'
import { SidebarComponent } from '../components/sidebar/sidebar.component'


const routes: Routes = [
  { path: "", component: AdministrationComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [AdministrationComponent],
  imports: [
    NgxModule,
    SidebarModule,
    RouterModule.forChild(routes),
  ],
  exports: [
    AdministrationComponent,
    RouterModule
  ]
})
export class AdministrationModule { }
