import { Component, OnInit } from "@angular/core";
import { HttpClient, HttpResponse } from "@angular/common/http";
import { ActivatedRoute, Router } from "@angular/router";

import { ClaimsApiService } from "@services/claims-api.service";

import { Subject } from 'rxjs';

@Component({
  selector: "app-claims-list",
  templateUrl: "./claims-list.component.html",
  styleUrls: ["./claims-list.component.scss"]
})
export class ClaimsListComponent implements OnInit {

  public dtOptions: DataTables.Settings = {};
  public dtTriggerClaim: Subject<any> = new Subject();
  public dtTriggerClaimExaption: Subject<any> = new Subject();

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
      if(res != null) {
        this.claims = res;
        this.claims = this.claims.newClaims;
        this.dtTriggerClaim.next();
      }
    });

    this.acs.getClaimsExceptionList(2020).subscribe(res => {
      if(res != null) {
        this.claimsException = res;
        this.claimsException = this.claimsException.newClaimsException;
        this.dtTriggerClaimExaption.next();
      }
    });
    
  }

  gotoClaim(id) {
    this.router.navigateByUrl(`/claims/${id}`);
  }

  ngOnInit() {
    this.getClaimsDetails();
  }

  ngOnDestroy(): void {
    this.dtTriggerClaim.unsubscribe();
    this.dtTriggerClaimExaption.unsubscribe();
  }

}
