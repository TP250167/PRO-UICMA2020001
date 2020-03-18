import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ConfigsLoaderService } from '../configs-loader.service'


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



}
