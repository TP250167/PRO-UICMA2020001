import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { DataTableDirective } from 'angular-datatables';
import { Subject } from 'rxjs';

import { RaApiService } from 'app/@services/ra-api.service'
import { ExcelService } from 'app/@services/excel.service'

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

  public dtTrigger: Subject<any> = new Subject();

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
      .subscribe((res) => {
        this.batchList = res;
      })
  }

  getBatcheInfo(id) {
    this.ras.getBatchDetails(id)
      .subscribe((res) => {
        this.batchInfo = res;
        this.raNotificationList(this.batchInfo.id)
      })
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
          this.dtTrigger.next();
        }
      )
  }

  getAllDeliverdRecipient(id) {
    this.dtElement.dtInstance
      .then((dtInstance: DataTables.Api) => {
        dtInstance.destroy();
        this.ras.getAllDeliverdRecipient(id)
          .subscribe((res) => {
            this.loglist = res;
            this.dtTrigger.next();
          })
      });
  }

  getAllFailedRecipient(id) {
    this.dtElement.dtInstance
      .then((dtInstance: DataTables.Api) => {
        dtInstance.destroy();
        this.ras.getAllFailedRecipient(id)
          .subscribe((res) => {
            this.loglist = res;
            this.dtTrigger.next();
          })
      });
  }

  rerenderDataTables(id): void {
    this.dtElement.dtInstance
      .then((dtInstance: DataTables.Api) => {
        dtInstance.destroy();
        this.getBatcheInfo(id)
      });
  }

  downloadCsv(id) {
    this.ras.getAllFailedRecipient(id)
      .subscribe((res) => {
        let csvData = res;
        if (Object.keys(csvData).length == 0) {
          csvData = [{ "message": 'No Data Available' }]
        }
        this.exs.downloadFile(csvData, 'failed_delivery.csv')
      })
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
