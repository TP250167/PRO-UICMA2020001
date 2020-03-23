import { NgModule } from '@angular/core';
import { NgxModule } from '@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { FullCalendarModule } from '@fullcalendar/angular'; // for FullCalendar!
import { SidebarModule } from './sidebar.module'

import { CalendarComponent } from '@components/calendar/calendar.component'
import { SidebarComponent } from '@components/sidebar/sidebar.component'

const routes: Routes = [
  { path: "", component: CalendarComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [
    CalendarComponent
  ],
  imports: [
    NgxModule,
    RouterModule.forChild(routes),
    SidebarModule,
    FullCalendarModule 
  ],
  exports: [
    RouterModule,
    CalendarComponent
  ]
})
export class CalendarModule { }
