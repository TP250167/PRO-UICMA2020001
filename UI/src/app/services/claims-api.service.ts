import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ConfigsLoaderService } from '../configs-loader.service'


@Injectable({
  providedIn: 'root'
})
export class ClaimsApiService {

  constructor(
    private http : HttpClient,
    private cls  : ConfigsLoaderService
  ) {
  }


  claimInitiate() {
    return this.http.post<any>(
      `https://jsonplaceholder.typicode.com/posts`,
      { title: 'Angular POST Request Example' }
    )
  }



}
