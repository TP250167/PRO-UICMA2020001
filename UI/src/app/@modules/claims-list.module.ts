import { NgModule } from '@angular/core';
import { NgxModule } from './ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { DataTablesModule } from 'angular-datatables';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { SidebarModule } from './sidebar.module'

 
import { ClaimsListComponent } from '../components/claims-list/claims-list.component'
import { SidebarComponent } from '../components/sidebar/sidebar.component'

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
    DataTablesModule,
    SidebarModule,
    CarouselModule.forRoot(),
  ],
  exports: [
    ClaimsListComponent,
    RouterModule,
    DataTablesModule,
  ]
})
export class ClaimsListModule { }
