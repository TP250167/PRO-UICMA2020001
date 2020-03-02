import { NgModule } from '@angular/core';
import { NgxModule } from './ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'

import { ClaimComponent } from '../components/claims-list/claim/claim.component'
import { SidebarProcessStepsComponent } from '../components/sidebar-process-steps/sidebar-process-steps.component'

const routes: Routes = [
  { path: "", component: ClaimComponent},
  { path: "", component: SidebarProcessStepsComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [
    ClaimComponent
  ],
  imports: [
    NgxModule,
    RouterModule.forChild(routes),
    SidebarModule,
  ],
  exports: [
    ClaimComponent,
    RouterModule,
  ]
})
export class ClaimModule { }
