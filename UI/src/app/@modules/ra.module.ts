import { NgModule } from '@angular/core';
import { NgxModule } from 'app/@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'
import { JqueryDatatableModule } from '../@modules/jquery-datatable.module'


//component
import { RaComponent } from 'app/@components/ra/ra.component'
import { SidebarComponent } from 'app/@components/sidebar/sidebar.component'
import { NotificationLogsComponent } from 'app/@components/ra/notification-logs/notification-logs.component';


const routes: Routes = [
  { path: "", component: RaComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
  { path: "notification-log/:id", component: NotificationLogsComponent},
]


@NgModule({
  declarations: [
    RaComponent,
    NotificationLogsComponent
  ],
  imports: [
    NgxModule,
    SidebarModule,
    JqueryDatatableModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule,
    JqueryDatatableModule,
    RaComponent,
    NotificationLogsComponent
  ]
})
export class RaModule { }
