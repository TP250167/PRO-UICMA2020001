import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { RaApiService } from '../../../services/ra-api.service'

@Component({
  selector: 'app-notification-logs',
  templateUrl: './notification-logs.component.html',
  styleUrls: ['./notification-logs.component.scss']
})
export class NotificationLogsComponent implements OnInit {

  public dtOptions  : any;
  public loglist    : any = [];

  public batchVal   : number;
  public bactchList : any = [] ;
  public bactchInfo : any = [] ;


  constructor(
    private http: HttpClient,
    private route: ActivatedRoute,
    private ras: RaApiService
  ) {

  }


  getBatchList(){
      this.ras.getAllBatch()
      .subscribe(
        (res) => {
          this.bactchList =  res ;
          console.log(this.bactchList)
        },
        (error) => {
          console.log('error caught in get batch list', error)
        }
      )
  }

  getBatcheInfo(id){
    this.ras.getBatchDetails(id)
    .subscribe(
      (res) => {
        this.bactchInfo = res ;
        this.raNotificationList(this.bactchInfo.id)
      },
      (error) => {
        console.log('error caught in get batch details', error)
      }
    )
  }

  raNotificationList(id) {

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 2
    };

    this.ras.getRaNotificationList(id)
      .subscribe(
        (res) => {
          this.loglist = res;
          console.log(res)
        },
        (error) => {
          console.log('error caught in batch creation', error)
        }
      )
  }


  ngOnInit() {

    this.getBatchList();
    
    let batchId = this.route.snapshot.paramMap.get('id');
    this.getBatcheInfo(batchId) 

    this.batchVal =  parseInt(batchId);

  }

}
