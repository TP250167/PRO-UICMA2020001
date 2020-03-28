import { Component, OnInit } from '@angular/core';

import { AppService } from 'app/@services/app.service'

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  constructor(
    public aps: AppService,
  ) { }

  ngOnInit() {
  }

}
