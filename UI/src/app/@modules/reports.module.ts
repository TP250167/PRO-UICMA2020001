import { NgModule } from '@angular/core';
import { NgxModule } from '@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'

import { ReportsComponent } from 'app/@components/reports/reports.component'
import { SidebarComponent } from 'app/@components/sidebar/sidebar.component'

const routes: Routes = [
  { path: "", component: ReportsComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]


@NgModule({
  declarations: [
    ReportsComponent
  ],
  imports: [
    NgxModule,
    SidebarModule,
    RouterModule.forChild(routes),
  ],
  exports: [
    RouterModule,
    ReportsComponent
  ]
})
export class ReportsModule { }
