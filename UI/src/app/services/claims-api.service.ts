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
    private http : HttpClient,
    private cls  : ConfigsLoaderService
  ) {
  }

  getClaimsList(year,status) {
    return this.http.get(
      `${this.cls.ApiUrl}api/NewClaim/GetActivesClaims/2020/Active`,
    )
  }

  getClaim(id) {
    return this.http.get<ClaimModel>(
      `${this.cls.ApiUrl}api/NewClaim/GetReqNumClaims/${id}`
    )
  }

  updateClaim(payloadData) {
    return this.http.post<ClaimModel>(
      `${this.cls.ApiUrl}api/NewClaim/AddandUpdateNewClaim`,
      payloadData
    )
  }


}
