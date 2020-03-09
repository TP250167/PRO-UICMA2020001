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
import { NoticeOfDeterminationComponent } from '../components/claims-list/steps/notice-of-determination/notice-of-determination.component';
import { ResponseToEmployerComponent } from '../components/claims-list/steps/response-to-employer/response-to-employer.component';
import { NoticeOfWagesComponent } from '../components/claims-list/steps/notice-of-wages/notice-of-wages.component';
import { AppealFormComponent } from '../components/claims-list/steps/appeal-form/appeal-form.component';

import { NoticeOfHearingComponent } from '../components/claims-list/steps/notice-of-hearing/notice-of-hearing.component'
import { AdditionalInfoComponent } from '../components/claims-list/steps/additional-info/additional-info.component'
import { EmployeeDataComponent } from '../components/claims-list/steps/employee-data/employee-data.component'
import { RequestForWagesComponent } from '../components/claims-list/steps/request-for-wages/request-for-wages.component';
import { BenefitAuditComponent } from '../components/claims-list/steps/benefit-audit/benefit-audit.component';
import { BenefitChargeComponent } from '../components/claims-list/steps/benefit-charge/benefit-charge.component';


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
    AcknowledgementComponent,
    NoticeOfDeterminationComponent,
    ResponseToEmployerComponent,
    NoticeOfWagesComponent,
    AppealFormComponent,
    NoticeOfHearingComponent,
    AdditionalInfoComponent,
    EmployeeDataComponent,
    RequestForWagesComponent,
    BenefitAuditComponent,
    BenefitChargeComponent 
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
    AcknowledgementComponent,
    NoticeOfDeterminationComponent,
    ResponseToEmployerComponent,
    NoticeOfWagesComponent,
    AppealFormComponent,
    NoticeOfHearingComponent,
    AdditionalInfoComponent,
    EmployeeDataComponent,
    RequestForWagesComponent,
    BenefitAuditComponent,
    BenefitChargeComponent 
  ]
})
export class ClaimModule { }
