import { NgModule } from '@angular/core';
import { NgxModule } from './ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'

import { ClaimComponent } from '../components/claims-list/claim/claim.component'
import { SidebarProcessStepsComponent } from '../components/sidebar-process-steps/sidebar-process-steps.component'


// step components 

import { ClaimInitComponent } from '../components/claims-list/steps/claim-init/claim-init.component'
import { InterviewComponent } from '../components/claims-list/steps/interview/interview.component'
import { AljDecisionComponent } from '../components/claims-list/steps/alj-decision/alj-decision.component'
import { AcknowledgementComponent } from '../components/claims-list/steps/acknowledgement/acknowledgement.component'


const routes: Routes = [
  { path: "", component: ClaimComponent},
  { path: "", component: SidebarProcessStepsComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [
    ClaimComponent,
    ClaimInitComponent,
    InterviewComponent,
    AljDecisionComponent,
    AcknowledgementComponent
  ],
  imports: [
    NgxModule,
    RouterModule.forChild(routes),
    SidebarModule,
  ],
  exports: [
    ClaimComponent,
    RouterModule,
    ClaimInitComponent,
    InterviewComponent,
    AljDecisionComponent,
    AcknowledgementComponent
  ]
})
export class ClaimModule { }
