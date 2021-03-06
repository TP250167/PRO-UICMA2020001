import { NgModule } from '@angular/core';
import { NgxModule } from 'app/@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'
import { AngularEditorModule } from '@kolkov/angular-editor';

import { AdministrationComponent } from 'app/@components/administration/administration.component'
import { SidebarComponent } from 'app/@components/sidebar/sidebar.component'
import { FormTemplateManagementComponent } from 'app/@components/administration/form-template-management/form-template-management.component';


const routes: Routes = [
  { path: "", component: AdministrationComponent, },
  { path: "template-management", component: FormTemplateManagementComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]

@NgModule({
  declarations: [
    AdministrationComponent,
    FormTemplateManagementComponent
  ],
  imports: [
    NgxModule,
    SidebarModule,
    RouterModule.forChild(routes),
    AngularEditorModule
  ],
  exports: [
    AdministrationComponent,
    FormTemplateManagementComponent,
    RouterModule,
    AngularEditorModule
  ]
})
export class AdministrationModule { }
