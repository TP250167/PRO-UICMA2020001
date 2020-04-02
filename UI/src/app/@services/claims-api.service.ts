import { Injectable } from "@angular/core";

import { HttpClient, HttpHeaders } from "@angular/common/http";
import { ConfigsLoaderService } from "../configs-loader.service";

// models
import { ClaimModel } from "app/@models/claims/claim.model";
import { ClaimDeterminationModel} from "app/@models/claims/claim-determination.model";
import { ResponseToEmployer } from "app/@models/claims/response-to-employer.model";
import { Wages } from "app/@models/claims/wages.model";
import { WagesAppeal } from "app/@models/claims/wages-appeal.model";
import { DeterminationAppeal } from "app/@models/claims/determination-appeal.model";
import { NoticeOfHearing } from "app/@models/claims/notice-of-hearing.model";
import { ALJDecision } from "app/@models/claims/aljdecision.model";
import { ClaimResponseModel } from "app/@models/claims/claim-response.model";
import { ClaimInterviewModel } from "app/@models/claims/claim-interview.model";
import { Additionalinfo } from "app/@models/claims/additionalinfo.model";
import { CUIABBoardAppeal } from "app/@models/claims/cuiabboard-appeal.model";
import { CUIABAcknowledgement } from "app/@models/claims/cuiabacknowledgement.model";
import { RequestForEmpData } from "app/@models/claims/request-for-emp-data.model";
import { WagesAfterAppeal } from "app/@models/claims/wages-after-appeal.model";
import { RequestToReopen } from "app/@models/claims/request-to-reopen.model";
import { BenefitCharge } from "app/@models/claims/benefit-charge.model";
import { BenefitAudit } from "app/@models/claims/benefit-audit.model";
import { ClaimAppeal } from "app/@models/claims/claim-appeal.model";


@Injectable({
  providedIn: "root"
})
export class ClaimsApiService {

  constructor(private http: HttpClient, private cls: ConfigsLoaderService) { }

  // claim list start
  getClaimsList(year, status) {
    return this.http.get(`${this.cls.ApiUrl}api/NewClaim/GetActivesClaims/2020/Active`);
  }

  getClaimsExceptionList(year) {
    return this.http.get(`${this.cls.ApiUrl}api/ClaimException/GetClaimException/2020`);
  }

  // claim list end


  // claim start
  getClaim(id) {
    return this.http.get<ClaimModel>(`${this.cls.ApiUrl}api/NewClaim/GetNewclaimbyID/${id}`);
  }

  updateClaim(payloadData) {
    return this.http.post<ClaimModel>(`${this.cls.ApiUrl}api/NewClaim/AddandUpdateNewClaim`, payloadData);
  }
  // claim end



  // DE1101 Response start
  getClaimResponseList() {
    return this.http.get<ClaimResponseModel>(`${this.cls.ApiUrl}api/ClaimResponse/GetClaimResponseAll`);
  }

  getClaimResponse(id) {
    return this.http.get<ClaimResponseModel>(`${this.cls.ApiUrl}api/ClaimResponse/GetClaimResponsebyID/${id}`);
  }

  updateClaimResponse(payloadData) {
    return this.http.post<ClaimResponseModel>(`${this.cls.ApiUrl}api/ClaimResponse/AddandUpdateClaimResponse`, payloadData);
  }
  // DE1101 Response end



  // DE1101 Interview start
  getClaimInterviewList() {
    return this.http.get<ClaimInterviewModel>(`${this.cls.ApiUrl}api/ClaimInterview/GetClaimInterviewAll`);
  }

  getClaimInterview(id) {
    return this.http.get<ClaimInterviewModel>(`${this.cls.ApiUrl}api/ClaimInterview/GetClaimInterviewbyID/${id}`);
  }

  updateClaimInterview(payloadData) {
    return this.http.post<ClaimInterviewModel>(`${this.cls.ApiUrl}api/ClaimInterview/AddandUpdateClaimInterview`, payloadData);
  }
  // DE1101 Interview end



  // DE1080 Notice of Determination start
  getClaimDeterminationList() {
    return this.http.get<ClaimDeterminationModel>(`${this.cls.ApiUrl}api/ClaimDetermination/GetClaimDeterminationAll`);
  }

  getClaimDetermination(id) {
    return this.http.get<ClaimDeterminationModel>(`${this.cls.ApiUrl}api/ClaimDetermination/GetClaimDeterminationbyID/${id}`);
  }

  updateClaimDetermination(payloadData) {
    return this.http.post<ClaimDeterminationModel>(`${this.cls.ApiUrl}api/ClaimDetermination/AddandUpdateClaimDetermination`, payloadData);
  }
  // DE1080 Notice of Determination end



  // DE4614 Response to Employer Communication start
  getResponsetoEmployerList() {
    return this.http.get<ResponseToEmployer>(`${this.cls.ApiUrl}api/ResponsetoEmployer/GetResponseToEmployerAll`);
  }

    getResponsetoEmployer(id) {
    return this.http.get<ResponseToEmployer>(`${this.cls.ApiUrl}api/ResponsetoEmployer/GetResponseToEmployerbyID/${id}`);
  }

  updateResponsetoEmployer(payloadData) {
    return this.http.post<ResponseToEmployer>(`${this.cls.ApiUrl}api/ResponsetoEmployer/AddandUpdateResponseToEmployer`, payloadData);
  }
  // DE4614 Response to Employer Communication end



  // DE4614 Appeal Form start
  getClaimAppealList() {
    return this.http.get<ClaimAppeal>(`${this.cls.ApiUrl}api/ClaimAppeal/GetclaimAppealAll`);
  }

  getClaimAppeal(id) {
    return this.http.get<ClaimAppeal>(`${this.cls.ApiUrl}api/ClaimAppeal/GetMasterApplicationbyId/${id}`);
  }

  updateClaimAppeal(payloadData) {
    return this.http.post<ClaimAppeal>(`${this.cls.ApiUrl}api/ClaimAppeal/AddandUpdateclaimAppeal`, payloadData);
  }
  // DE4614 Appeal Form end



  // DE1545 Notice of Wages start
  getWagesList() {
    return this.http.get<Wages>(`${this.cls.ApiUrl}api/Wages/GetWagesAll`);
  }

  getWages(id) {
    return this.http.get<Wages>(`${this.cls.ApiUrl}api/Wages/GetWagesbyID/${id}`);
  }

  updateWages(payloadData) {
    return this.http.post<Wages>(`${this.cls.ApiUrl}api/Wages/AddandUpdateWages`, payloadData);
  }
  // DDE1545 Notice of Wages end



  // DE1545 Appeal Form start
  getWagesAppealList() {
    return this.http.get<WagesAppeal>(`${this.cls.ApiUrl}api/WagesAppeal/GetWagesAppealAll`);
  }

  getWagesAppeal(id) {
    return this.http.get<WagesAppeal>(`${this.cls.ApiUrl}api/WagesAppeal/GetWagesAppealbyID/${id}`);
  }

  updateWagesAppeal(payloadData) {
    return this.http.post<WagesAppeal>(`${this.cls.ApiUrl}api/WagesAppeal/AddandUpdateWagesAppeal`, payloadData);
  }
  // DE1545 Appeal Form end



  // 1000M Appeal Form start
  getDeterminationAppealList() {
    return this.http.get<DeterminationAppeal>(`${this.cls.ApiUrl}api/DeterminationAppeal/GetDeterminationAppealAll`);
  }

  getDeterminationAppeal(id) {
    return this.http.get<DeterminationAppeal>(`${this.cls.ApiUrl}api/DeterminationAppeal/GetDeterminationAppealbyID/${id}`);
  }

  updateDeterminationAppeal(payloadData) {
    return this.http.post<DeterminationAppeal>(`${this.cls.ApiUrl}api/DeterminationAppeal/AddandUpdateDeterminationAppeal`, payloadData);
  }
  // 1000M Appeal Form end


  // Notice of Hearing start
  getHearingNotificationList() {
    return this.http.get<NoticeOfHearing>(`${this.cls.ApiUrl}api/HearingNotification/GetHearingAll`);
  }

  getHearingNotification(id) {
    return this.http.get<NoticeOfHearing>(`${this.cls.ApiUrl}api/HearingNotification/GetHearingbyID/${id}`);
  }

  updateHearingNotification(payloadData) {
    return this.http.post<NoticeOfHearing>(`${this.cls.ApiUrl}api/HearingNotification/AddandUpdateHearing`, payloadData);
  }
  // Notice of Hearing end



  // ALJ Decision start
  getALJDecisionList() {
    return this.http.get<ALJDecision>(`${this.cls.ApiUrl}api/ALJDecision/GetALJDecisionAll`);
  }

  getALJDecision(id) {
    return this.http.get<ALJDecision>(`${this.cls.ApiUrl}api/ALJDecision/GetALJDecisionbyID/${id}`);
  }

  updateALJDecision(payloadData) {
    return this.http.post<ALJDecision>(`${this.cls.ApiUrl}api/ALJDecision/AddandUpdateALJDecision`, payloadData);
  }
  // ALJ Decision end



  // Acknowledgement start
  getAcknowledgementList() {
    return this.http.get<CUIABAcknowledgement>(`${this.cls.ApiUrl}api/CUIABAcknow/GetCUIABAcknowAll`);
  }

  getAcknowledgement(id){
    return this.http.get<CUIABAcknowledgement>(`${this.cls.ApiUrl}api/CUIABAcknow/GetCUIABAcknowbyID/${id}`);
  }

  updateAcknowledgement(payloadData) {
    return this.http.post<CUIABAcknowledgement>(`${this.cls.ApiUrl}api/CUIABAcknow/AddandUpdateCUIABAcknow`, payloadData);
  }
  // Acknowledgement end



  // CUIAB Board Appeal 1430 start
  getCUIABBoardAppealList() {
    return this.http.get<CUIABBoardAppeal>(`${this.cls.ApiUrl}api/CUIABBoardAppeal/GetCUIABBoardAppealAll`);
  }

  getCUIABBoardAppeal(id) {
    return this.http.get<CUIABBoardAppeal>(`${this.cls.ApiUrl}api/CUIABBoardAppeal/GetCUIABBoardAppealbyID/${id}`);
  }

  updateCUIABBoardAppeal(payloadData) {
    return this.http.post<CUIABBoardAppeal>(`${this.cls.ApiUrl}api/CUIABBoardAppeal/AddandUpdateCUIABBoardAppeal`, payloadData);
  }
  // CUIAB Board Appeal 1430 end



  // DE1326 Request for Additional Information start
  getAdditionalInfoList() {
    return this.http.get<Additionalinfo>(`${this.cls.ApiUrl}api/AdditionalInfo/GetAdditionalInfoAll`);
  }

  getAdditionalInfo(id) {
    return this.http.get<Additionalinfo>(`${this.cls.ApiUrl}api/AdditionalInfo/GetAdditionalInfobyID/${id}`);
  }

  updateAdditionalInfo(payloadData) {
    return this.http.post<Additionalinfo>(`${this.cls.ApiUrl}api/AdditionalInfo/AddandUpdateAdditionalInfo`, payloadData);
  }
  // DE1326 Request for Additional Information end



  // 6363 Request for Employee Data start
  getRequestForEmpDataList() {
    return this.http.get<RequestForEmpData>(`${this.cls.ApiUrl}api/RequestForEmpData/GetRequestForEmpDataAll`);
  }

  getRequestForEmpData(id) {
    return this.http.get<RequestForEmpData>(`${this.cls.ApiUrl}api/RequestForEmpData/GetRequestForEmpDatabyID/${id}`);
  }

  updateRequestForEmpData(payloadData) {
    return this.http.post<RequestForEmpData>(`${this.cls.ApiUrl}api/RequestForEmpData/AddandUpdateRequestForEmpData`, payloadData);
  }
  // 6363 Request for Employee Data end



  // DE1919 Request for Wages start
  getWagesAfterAppealList() {
    return this.http.get<WagesAfterAppeal>(`${this.cls.ApiUrl}api/WagesAfterAppeal/GetWagesAfterAppealAll`);
  }

  getWagesAfterAppeal(id) {
    return this.http.get<WagesAfterAppeal>(`${this.cls.ApiUrl}api/WagesAfterAppeal/GetWagesAfterAppealbyID/${id}`);
  }

  updateWagesAfterAppeal(payloadData) {
    return this.http.post<WagesAfterAppeal>(`${this.cls.ApiUrl}api/WagesAfterAppeal/AddandUpdateWagesAfterAppeal`, payloadData);
  }
  // DE1919 Request for Wages end



  //DE1296 Benefit Audit start 
  getBenefitAuditList() {
    return this.http.get<BenefitAudit>(`${this.cls.ApiUrl}api/BenefitAudit/GetBenefitAuditAll`);
  }

  getBenefitAudit(id) {
    return this.http.get<BenefitAudit>(`${this.cls.ApiUrl}api/BenefitAudit/GetBenefitAuditbyID/${id}`);
  }

  updateBenefitAudit(payloadData) {
    return this.http.post<BenefitAudit>(`${this.cls.ApiUrl}api/BenefitAudit/AddandUpdateBenefitAudit`, payloadData);
  }
  // DE1296 Benefit Audit end



  // 428F Benefit Charges start
  getBenefitChargeList() {
    return this.http.get<BenefitCharge>(`${this.cls.ApiUrl}api/BenefitCharge/GetBenefitChargeAll`);
  }

  getBenefitCharge(id) {
    return this.http.get<BenefitCharge>(`${this.cls.ApiUrl}api/BenefitCharge/GetBenefitChargebyID/${id}`);
  }

  updateBenefitCharge(payloadData) {
    return this.http.post<BenefitCharge>(`${this.cls.ApiUrl}api/BenefitCharge/AddandUpdateBenefitCharge`, payloadData);
  }
  // 428F Benefit Charges start


  // Request to Re-open start
  getRequestToReopenList() {
    return this.http.get<RequestToReopen>(`${this.cls.ApiUrl}api/RequestToReopen/GetRequestToReopenAll`);
  }

  getRequestToReopen(id) {
    return this.http.get<RequestToReopen>(`${this.cls.ApiUrl}api/RequestToReopen/GetRequestToReopenbyID/${id}`);
  }

  updateRequestToReopen(payloadData) {
    return this.http.post<RequestToReopen>(`${this.cls.ApiUrl}api/RequestToReopen/AddandUpdateRequestToReopen`, payloadData);
  }
  // Request to Re-open end


}
