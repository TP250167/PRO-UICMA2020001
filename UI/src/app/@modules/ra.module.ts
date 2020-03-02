import { NgModule } from '@angular/core';
import { NgxModule } from '../@modules/ngx.module'
import { RouterModule, Routes } from '@angular/router';
import { SidebarModule } from './sidebar.module'

import { RaComponent } from '../components/ra/ra.component'
import { SidebarComponent } from '../components/sidebar/sidebar.component'

const routes: Routes = [
  { path: "", component: RaComponent, },
  { path: "", component: SidebarComponent, outlet: 'sidebar' },
]


@NgModule({
  declarations: [
    RaComponent
  ],
  imports: [
    NgxModule,
    SidebarModule,
    RouterModule.forChild(routes),
  ],
  exports: [
    RouterModule,
    RaComponent
  ]
})
export class RaModule { }
