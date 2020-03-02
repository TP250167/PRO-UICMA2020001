import { NgModule } from '@angular/core';
import { NgxModule } from '../@modules/ngx.module'
import { ChartsModule } from 'ng2-charts';
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'

import { DashboardComponent } from '../components/dashboard/dashboard.component';
import { LineChartComponent } from '../components/dashboard/charts/line-chart/line-chart.component';
import { BarChartComponent } from '../components/dashboard/charts/bar-chart/bar-chart.component';
import { PieChartComponent } from '../components/dashboard/charts/pie-chart/pie-chart.component';

import { SidebarComponent } from '../components/sidebar/sidebar.component'

const routes: Routes = [
  { path: "", component: DashboardComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [
    DashboardComponent,
    LineChartComponent,
    BarChartComponent,
    PieChartComponent,
  ],
  imports: [
    NgxModule,
    ChartsModule,
    SidebarModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    DashboardComponent,
    LineChartComponent,
    BarChartComponent,
    PieChartComponent,
    RouterModule,
  ]
})
export class DashboardModule { }