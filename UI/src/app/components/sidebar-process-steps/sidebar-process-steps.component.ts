import { Component, OnInit , ViewChild} from '@angular/core';

import { ClaimsService } from '../../services/claims.service'

@Component({
  selector: 'app-sidebar-process-steps',
  templateUrl: './sidebar-process-steps.component.html',
  styleUrls: ['./sidebar-process-steps.component.scss']
})
export class SidebarProcessStepsComponent implements OnInit {

  

  constructor(public cs:ClaimsService) { }

  ngOnInit() {
    
  }

}
