import { Component, OnInit } from "@angular/core";
import { HttpClient, HttpResponse } from "@angular/common/http";
import { ActivatedRoute, Router } from "@angular/router";

import { ClaimsApiService } from "@services/claims-api.service";

@Component({
  selector: "app-claims-list",
  templateUrl: "./claims-list.component.html",
  styleUrls: ["./claims-list.component.scss"]
})
export class ClaimsListComponent implements OnInit {
  public dtOptions: any;
  public claims: any;
  public claimsException: any;

  constructor(
    private http: HttpClient,
    private router: Router,
    private acs: ClaimsApiService
  ) { }

  getClaimsDetails() {
    this.dtOptions = {
      pagingType: "full_numbers",
      pageLength: 5
    };

    this.acs.getClaimsList(2020, "Active").subscribe(res => {
      this.claims = res;
      this.claims = this.claims.newClaims;
    });

    this.acs.getClaimsExceptionList(2020, "Exception").subscribe(res => {
      this.claimsException = res;
      this.claimsException = this.claimsException.newClaims;
    });
    
  }

  gotoClaim(id) {
    this.router.navigateByUrl(`/claims/${id}`);
  }

  ngOnInit() {
    this.getClaimsDetails();
  }
}
