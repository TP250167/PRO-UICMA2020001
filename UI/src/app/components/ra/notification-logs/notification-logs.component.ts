import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { DataTableDirective } from 'angular-datatables';
import { Subject } from 'rxjs';

import { RaApiService } from '@services/ra-api.service'
import { ExcelService } from '@services/excel.service'

@Component({
  selector: 'app-notification-logs',
  templateUrl: './notification-logs.component.html',
  styleUrls: ['./notification-logs.component.scss']
})
export class NotificationLogsComponent implements OnInit {

  @ViewChild(DataTableDirective, { static: false })
  dtElement: DataTableDirective;


  public dtOptions: DataTables.Settings = {};
  public loglist: any = [];

  dtTrigger: Subject<any> = new Subject();


  public batchVal: number;
  public batchList: any = [];
  public batchInfo: any = [];


  constructor(
    private http: HttpClient,
    private route: ActivatedRoute,
    private ras: RaApiService,
    private exs: ExcelService
  ) {

  }

  getBatchList() {
    this.ras.getAllBatchList()
      .subscribe(
        (res) => {
          this.batchList = res;
        },
        (error) => {
          console.log('error caught in get batch list', error)
        }
      )
  }

  getBatcheInfo(id) {
    this.ras.getBatchDetails(id)
      .subscribe(
        (res) => {
          this.batchInfo = res;
          this.raNotificationList(this.batchInfo.id)
        },
        (error) => {
          console.log('error caught in get batch details', error)
        }
      )
  }

  raNotificationList(id) {

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5,
    };

    this.ras.getRaNotificationList(id)
      .subscribe(
        (res) => {
          this.loglist = res;
          console.log(this.loglist)
          this.dtTrigger.next();
        },
        (error) => {
          console.log('error caught in batch creation', error)
        }
      )
  }

  getAllDeliverdRecipient(id) {
    this.dtElement.dtInstance
      .then((dtInstance: DataTables.Api) => {
        dtInstance.destroy();
        this.ras.getAllDeliverdRecipient(id)
          .subscribe(
            (res) => {
              this.loglist = res;
              this.dtTrigger.next();
              console.log(res)
            },
            (error) => {
              console.log('error caught in batch creation', error)
            }
          )
      });
  }

  getAllFailedRecipient(id) {
    this.dtElement.dtInstance
      .then((dtInstance: DataTables.Api) => {
        dtInstance.destroy();
        this.ras.getAllFailedRecipient(id)
          .subscribe(
            (res) => {
              this.loglist = res;
              this.dtTrigger.next();
              console.log(res)
            },
            (error) => {
              console.log('error caught in batch creation', error)
            }
          )
      });
  }

  rerenderDataTables(id): void {
    this.dtElement.dtInstance
      .then((dtInstance: DataTables.Api) => {
        console.log(dtInstance)
        dtInstance.destroy();
        this.getBatcheInfo(id)
      });
  }

  downloadCsv(id) {
    this.ras.getAllFailedRecipient(id)
      .subscribe(
        (res) => {
          let csvData = res; 
          if(Object.keys(csvData).length == 0) { 
            csvData = [{"message":'No Data Available'}]
          } 
          console.log(csvData)
          this.exs.downloadFile(csvData, 'failed_delivery.csv')
        },
        (error) => { console.log('error caught in download csv creation', error) }
      )
  }

  ngOnInit() {

    this.getBatchList();

    let batchId = this.route.snapshot.paramMap.get('id');
    this.getBatcheInfo(batchId)

    this.batchVal = parseInt(batchId);

  }

  ngOnDestroy(): void {
    this.dtTrigger.unsubscribe();
  }

}
