import { NgModule } from '@angular/core';
import { NgxModule } from '../@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'
import { JqueryDatatableModule } from '../@modules/jquery-datatable.module'


//component
import { RaComponent } from '../components/ra/ra.component'
import { SidebarComponent } from '../components/sidebar/sidebar.component'
import { NotificationLogsComponent } from '../components/ra/notification-logs/notification-logs.component';


const routes: Routes = [
  { path: "", component: RaComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
  { path: "notification-log", component: NotificationLogsComponent},
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
