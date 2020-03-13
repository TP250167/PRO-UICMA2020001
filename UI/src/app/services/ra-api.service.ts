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


  getBatchDetails(id){
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetBatchViewbyID/${id}`
    )
  }
  
  getRecipient() {
    return this.http.get(
      `${this.cls.ApiUrl}api/RARecipientRule/GetAllRARecipientRule`
    )
  }
  
  getRaNotificationList(id){
    return this.http.get(
      `${this.cls.ApiUrl}api/RABatch/GetRANotificationList/${id}`
    )
  }



}
