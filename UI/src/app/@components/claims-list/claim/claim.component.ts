import { Component, OnInit } from '@angular/core';
import { ClaimsService  } from  'app/@services/claims.service'

@Component({
  selector: 'app-claim',
  templateUrl: './claim.component.html',
  styleUrls: ['./claim.component.scss']
})

export class ClaimComponent implements OnInit {

  constructor(public cs : ClaimsService ) {

  }

  ngOnInit() {
    
  }

}
