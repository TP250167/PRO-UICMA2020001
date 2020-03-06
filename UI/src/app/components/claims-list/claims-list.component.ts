import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';


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
  ) {

  }

  getClaimsDetails() {

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5
    };

    this.http.get('http://localhost:3000/claims')
      .subscribe(res => {
        this.claims = res;
      });

  }

  gotoClaim(id) {
    this.router.navigateByUrl(`/claims/${id}`);
  }


  ngOnInit() {
    this.getClaimsDetails()
  }
  
}
