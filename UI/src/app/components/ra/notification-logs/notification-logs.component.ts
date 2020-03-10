import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-notification-logs',
  templateUrl: './notification-logs.component.html',
  styleUrls: ['./notification-logs.component.scss']
})
export class NotificationLogsComponent implements OnInit {

  public dtOptions: any;
  public loglist: any;

  constructor(
    private http: HttpClient,
    private router: Router,
  ) {

  }

  getLogListDetails() {

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5
    };

    this.http.get('http://localhost:3000/loglist')
      .subscribe(res => {
        this.loglist = res;
      });

  }




  ngOnInit() {
    this.getLogListDetails()
  }

}
