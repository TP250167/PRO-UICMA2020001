import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ConfigsLoaderService } from '../configs-loader.service'

//models
import { RaAllBatchModel } from "app/@models/ra/ra-all-batch.model";
import { RaAllBatchListModel } from "app/@models/ra/ra-all-batchlist.model";
import { RaAllDeliverdRecipientModel } from "app/@models/ra/ra-all-deliverd-recipient-model";
import { RaAllFailedRecipientModel } from "app/@models/ra/ra-all-failed-recipient-model";
import { RaBatchDetailsModel } from "app/@models/ra/ra-batch-details-model";
import { RaNotificationListModel } from "app/@models/ra/ra-notification-list-model";
import { RaRecipientModel } from "app/@models/ra/ra-recipient-model";
import { RaTemplateIdModel } from "app/@models/ra/ra-templateId-model";
import { RaWeeklyBatchModel } from "app/@models/ra/ra-weekly-batch-model";


@Injectable({
  providedIn: 'root'
})
export class RaApiService {

  constructor(
    private http : HttpClient,
    private cls  : ConfigsLoaderService
  ) {

  }


  // Batch creation 
  createBatch(payloadData) {
    return this.http.post(
      `${this.cls.ApiUrl}api/RABatch/CreateBatch`,
      payloadData
    )
  }

  getAllBatch(){
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetAllRABatch`
    )
  }

  getAllBatchList(){
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetAllBatch`
    )
  }

  getBatchDetails(id){
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetBatchViewbyID/${id}`
    )
  }

  getRaWeeklyBatch() {
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetAllRABiWeeklyBatch`
    )
  }
  
  getRecipient(boolval) {
    return this.http.get(
      `${this.cls.ApiUrl}api/RARecipientRule/GetAllRARecipientRuleByAnnual/${boolval}`
    )
  }

  getTemplateId(){
    return this.http.get(
      `${this.cls.ApiUrl}api/RATemplate/GetAllTemplate`
    )
  }

  
  getRaNotificationList(id){
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetRANotificationList/${id}`
    )
  }

  getAllDeliverdRecipient(id){
    return this.http.get(
      `${this.cls.ApiUrl}api/RARecipient/GetAllDeliverdRecipient/${id}`
    )
  }

  getAllFailedRecipient(id){
    return this.http.get(
      `${this.cls.ApiUrl}api/RARecipient/GetAllFailedRecipient/${id}`
    )
  }


}
