import { NgModule } from '@angular/core';
import { NgxModule } from './ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { SidebarModule } from './sidebar.module'
import { JqueryDatatableModule } from '../@modules/jquery-datatable.module'
 

import { ClaimsListComponent } from 'app/@components/claims-list/claims-list.component'
import { SidebarComponent } from 'app/@components/sidebar/sidebar.component'

const routes: Routes = [
  { path: "", component: ClaimsListComponent},
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [
    ClaimsListComponent,
  ],
  imports: [
    NgxModule,
    RouterModule.forChild(routes),
    JqueryDatatableModule,
    SidebarModule,
    CarouselModule.forRoot(),
  ],
  exports: [
    ClaimsListComponent,
    RouterModule,
    JqueryDatatableModule,
  ]
})
export class ClaimsListModule { }
