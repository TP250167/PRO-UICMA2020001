import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ConfigsLoaderService } from '../configs-loader.service'


// models 
import { ClaimModel } from '../@models/claims/claim-model'


@Injectable({
  providedIn: 'root'
})
export class ClaimsApiService {

  constructor(
    private http: HttpClient,
    private cls: ConfigsLoaderService
  ) {
  }


  getClaimsList() {
    return this.http.get<ClaimModel>(
      `${this.cls.ApiUrl}/api/NewClaim/GetNewClaimAll`
    )
  }

  getClaim(id) {
    return this.http.get<ClaimModel>(
      `${this.cls.ApiUrl}/api/NewClaim/GetNewclaimbyID/${id}`
    )
  }

  updateClaim(payloadData) {
    return this.http.get<ClaimModel>(
      `${this.cls.ApiUrl}/api/NewClaim/AddandUpdateNewClaim`,
      payloadData
    )
  }


}
