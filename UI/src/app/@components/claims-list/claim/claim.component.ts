import { Component, OnInit } from '@angular/core';

import { AppService } from 'app/@services/app.service'

import { ClaimsService } from 'app/@services/claims.service'

@Component({
  selector: 'app-claim',
  templateUrl: './claim.component.html',
  styleUrls: ['./claim.component.scss']
})

export class ClaimComponent implements OnInit {

  constructor(
    public  aps  : AppService,
    public cs: ClaimsService
    ) {

  }

  ngOnInit() {

  }

}
