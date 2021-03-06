import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full'},
  { path: 'dashboard', loadChildren: "./dashboard.module#DashboardModule" },
  { path: 'calendar', loadChildren: "./calendar.module#CalendarModule" },
  { path: 'ra', loadChildren: "./ra.module#RaModule" },
  { path: 'claims', loadChildren: "./claims-list.module#ClaimsListModule" },
  { path: 'claims/:id', loadChildren: "./claim.module#ClaimModule" },
  { path: 'reports', loadChildren: "./reports.module#ReportsModule" },
  { path: 'administration', loadChildren: "./administration.module#AdministrationModule" },
  { path: '**' , redirectTo : '/dashboard'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
