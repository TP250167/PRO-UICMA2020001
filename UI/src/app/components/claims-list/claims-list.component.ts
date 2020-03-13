import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { ClaimsApiService } from '../../services/claims-api.service'



@Component({
  selector: 'app-claims-list',
  templateUrl: './claims-list.component.html',
  styleUrls: ['./claims-list.component.scss']
})
export class ClaimsListComponent implements OnInit {

  public dtOptions: any;
  public claims: any;

  constructor(
    private http: HttpClient,
    private router: Router,
    private acs: ClaimsApiService
  ) {

  }

  getClaimsDetails() {

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5
    };

    this.acs.getClaimsList()
      .subscribe(
        (res) => {
          this.claims = res
          console.log(this.claims)
        },
        (error) => {
          console.log('error caught in claim list component', error)
        }
      )

  }

  gotoClaim(id) {
    this.router.navigateByUrl(`/claims/${id}`);
  }


  ngOnInit() {
    this.getClaimsDetails()
  }

}
