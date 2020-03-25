import { Injectable } from "@angular/core";

import { HttpClient, HttpHeaders } from "@angular/common/http";
import { ConfigsLoaderService } from "../configs-loader.service";

// models
import { ClaimModel } from "app/@models/claims/claim.model";

@Injectable({
  providedIn: "root"
})
export class ClaimsApiService {

  constructor(private http: HttpClient, private cls: ConfigsLoaderService) { }

  // claim list start
  getClaimsList(year, status) {
    return this.http.get(`${this.cls.ApiUrl}api/NewClaim/GetActivesClaims/2020/Active`);
  }

  getClaimsExceptionList(year, status) {
    return this.http.get(`${this.cls.ApiUrl}api/NewClaim/GetActivesClaims/2020/Exception`);
  }
  getClaim(id) {
    return this.http.get<ClaimModel>(`${this.cls.ApiUrl}api/NewClaim/GetReqNumClaims/${id}`);
  }

  updateClaim(payloadData) {
    return this.http.post<ClaimModel>(`${this.cls.ApiUrl}api/NewClaim/AddandUpdateNewClaim`, payloadData);
  }
  // claim list end

  

  // DE1101 Response start
  getClaimResponseList() {
    return this.http.get(`${this.cls.ApiUrl}api/ClaimResponse/GetClaimResponseAll`);
  }

  getClaimResponse(id){
    return this.http.get(`${this.cls.ApiUrl}api/ClaimResponse/GetClaimResponsebyID/${id}`);
  }

  updateClaimResponse(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimResponse/AddandUpdateClaimResponse`, payloadData);
  }
  // DE1101 Response end



  // DE1101 Interview start
  getClaimInterviewList() {
    return this.http.get(`${this.cls.ApiUrl}api/ClaimInterview/GetClaimInterviewAll`);
  }

  getClaimInterview(id){
    return this.http.get(`${this.cls.ApiUrl}api/ClaimInterview/GetClaimInterviewbyID/${id}`);
  }

  updateClaimInterview(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimInterview/AddandUpdateClaimInterview`, payloadData);
  }
  // DE1101 Interview end



  // DE1080 Notice of Determination start
  getClaimDeterminationList() {
    return this.http.get(`${this.cls.ApiUrl}api/ClaimDetermination/GetClaimDeterminationAll`);
  }

  getClaimDetermination(id){
    return this.http.get(`${this.cls.ApiUrl}api/ClaimDetermination/GetClaimDeterminationbyID/${id}`);
  }

  updateClaimDetermination(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimDetermination/AddandUpdateClaimDetermination`, payloadData);
  }
  // DE1080 Notice of Determination end



  // DE4614 Response to Employer Communication start
  getResponsetoEmployerList() {
    return this.http.get(`${this.cls.ApiUrl}api/ResponsetoEmployer/GetResponseToEmployerAll`);
  }

  getResponsetoEmployer(id){
    return this.http.get(`${this.cls.ApiUrl}api/ResponsetoEmployer/GetResponseToEmployerbyID/${id}`);
  }

  updateResponsetoEmployer(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/ResponsetoEmployer/AddandUpdateResponseToEmployer`, payloadData);
  }
  // DE4614 Response to Employer Communication end



  // // DE4614 Appeal Form start
  // getClaimAppealList() {
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetclaimAppealAll`);
  // }

  // getClaimAppeal(id){
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetMasterApplicationbyId/${id}`);
  // }

  // updateClaimAppeal(payloadData) {
  //   return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimAppeal/AddandUpdateclaimAppeal`, payloadData);
  // }
  // // DE4614 Appeal Form end



  // // DE1545 Notice of Wages start
  // getClaimAppealList() {
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetclaimAppealAll`);
  // }

  // getClaimAppeal(id){
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetMasterApplicationbyId/${id}`);
  // }

  // updateClaimAppeal(payloadData) {
  //   return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimAppeal/AddandUpdateclaimAppeal`, payloadData);
  // }
  // // DDE1545 Notice of Wages end



  // DE1545 Appeal Form start
  getWagesAppealList() {
    return this.http.get(`${this.cls.ApiUrl}api/WagesAppeal/GetWagesAppealAll`);
  }

  getWagesAppeal(id){
    return this.http.get(`${this.cls.ApiUrl}api/WagesAppeal/GetWagesAppealbyID/${id}`);
  }

  updateWagesAppeal(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/WagesAppeal/AddandUpdateWagesAppeal`, payloadData);
  }
  // DE1545 Appeal Form end



  // // 1000M Appeal Form start
  // getClaimAppealList() {
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetclaimAppealAll`);
  // }

  // getClaimAppeal(id){
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetMasterApplicationbyId/${id}`);
  // }

  // updateClaimAppeal(payloadData) {
  //   return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimAppeal/AddandUpdateclaimAppeal`, payloadData);
  // }
  // // 1000M Appeal Form end


  // Notice of Hearing start
  getHearingNotificationList() {
    return this.http.get(`${this.cls.ApiUrl}api/HearingNotification/GetHearingAll`);
  }

  getHearingNotification(id){
    return this.http.get(`${this.cls.ApiUrl}api/HearingNotification/GetHearingbyID/${id}`);
  }

  updateHearingNotification(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/HearingNotification/AddandUpdateHearing`, payloadData);
  }
  // Notice of Hearing end



  // ALJ Decision start
  getALJDecisionList() {
    return this.http.get(`${this.cls.ApiUrl}api/ALJDecision/GetALJDecisionAll`);
  }

  getALJDecision(id){
    return this.http.get(`${this.cls.ApiUrl}api/ALJDecision/GetALJDecisionbyID/${id}`);
  }

  updateALJDecision(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/ALJDecision/AddandUpdateALJDecision`, payloadData);
  }
  // ALJ Decision end



  // // Acknowledgement start
  // getClaimAppealList() {
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetclaimAppealAll`);
  // }

  // getClaimAppeal(id){
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetMasterApplicationbyId/${id}`);
  // }

  // updateClaimAppeal(payloadData) {
  //   return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimAppeal/AddandUpdateclaimAppeal`, payloadData);
  // }
  // // Acknowledgement end



  // CUIAB Board Appeal 1430 start
  getCUIABBoardAppealList() {
    return this.http.get(`${this.cls.ApiUrl}api/CUIABBoardAppeal/GetCUIABBoardAppealAll`);
  }

  getCUIABBoardAppeal(id){
    return this.http.get(`${this.cls.ApiUrl}api/CUIABBoardAppeal/GetCUIABBoardAppealbyID/${id}`);
  }

  updateCUIABBoardAppeal(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/CUIABBoardAppeal/AddandUpdateCUIABBoardAppeal`, payloadData);
  }
  // CUIAB Board Appeal 1430 end



  // DE1326 Request for Additional Information start
  getAdditionalInfoList() {
    return this.http.get(`${this.cls.ApiUrl}api/AdditionalInfo/GetAdditionalInfoAll`);
  }

  getAdditionalInfo(id){
    return this.http.get(`${this.cls.ApiUrl}api/AdditionalInfo/GetAdditionalInfobyID/${id}`);
  }

  updateAdditionalInfo(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/AdditionalInfo/AddandUpdateAdditionalInfo`, payloadData);
  }
  // DE1326 Request for Additional Information end



  // 6363 Request for Employee Data start
  getRequestForEmpDataList() {
    return this.http.get(`${this.cls.ApiUrl}api/RequestForEmpData/GetRequestForEmpDataAll`);
  }

  getRequestForEmpData(id){
    return this.http.get(`${this.cls.ApiUrl}api/RequestForEmpData/GetRequestForEmpDatabyID/${id}`);
  }

  updateRequestForEmpData(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/RequestForEmpData/AddandUpdateRequestForEmpData`, payloadData);
  }
  // 6363 Request for Employee Data end



  // // DE1919 Request for Wages start
  // getClaimAppealList() {
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetclaimAppealAll`);
  // }

  // getClaimAppeal(id){
  //   return this.http.get(`${this.cls.ApiUrl}api/ClaimAppeal/GetMasterApplicationbyId/${id}`);
  // }

  // updateClaimAppeal(payloadData) {
  //   return this.http.post<any>(`${this.cls.ApiUrl}api/ClaimAppeal/AddandUpdateclaimAppeal`, payloadData);
  // }
  // // DE1919 Request for Wages end



  //DE1296 Benefit Audit start 
  getBenefitAuditList() {
    return this.http.get(`${this.cls.ApiUrl}api/BenefitAudit/GetBenefitAuditAll`);
  }

  getBenefitAudit(id){
    return this.http.get(`${this.cls.ApiUrl}api/BenefitAudit/GetBenefitAuditbyID/${id}`);
  }

  updateBenefitAudit(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/BenefitAudit/AddandUpdateBenefitAudit`, payloadData);
  }
  // DE1296 Benefit Audit end



  // 428F Benefit Charges start
  getBenefitChargeList() {
    return this.http.get(`${this.cls.ApiUrl}api/BenefitCharge/GetBenefitChargeAll`);
  }

  getBenefitCharge(id){
    return this.http.get(`${this.cls.ApiUrl}api/BenefitCharge/GetBenefitChargebyID/${id}`);
  }

  updateBenefitCharge(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/BenefitCharge/AddandUpdateBenefitCharge`, payloadData);
  }
  // 428F Benefit Charges start


  // Request to Re-open start
  getRequestToReopenList() {
    return this.http.get(`${this.cls.ApiUrl}api/RequestToReopen/GetRequestToReopenAll`);
  }

  getRequestToReopen(id){
    return this.http.get(`${this.cls.ApiUrl}api/RequestToReopen/GetRequestToReopenbyID/${id}`);
  }

  updateRequestToReopen(payloadData) {
    return this.http.post<any>(`${this.cls.ApiUrl}api/RequestToReopen/AddandUpdateRequestToReopen`, payloadData);
  }
  // Request to Re-open end


}
