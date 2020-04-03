using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA_OCR_Extraction
{
  public  class OCRExtractionBO
    {
        public class ClaimException
        {
            public Int64 Id { get; set; }
            public Int64? ClaimId { get; set; }
            public Int64? DocumentId { get; set; }
            public Int64? FormId { get; set; }
            public string ExceptionReason { get; set; }
            public DateTime? ExceptionDate { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
        }
        public class Claim
        {
            public Int64 Id { get; set; }
            public string RequestNumber { get; set; }
            public string Type { get; set; }
            public string RequestTitle { get; set; }
            public string ClaimantName { get; set; }
            public string CurrentStage { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public string Gender { get; set; }
            public string EmployeeNumber { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public string ReasonForSeparation { get; set; }
            public string NewClaim { get; set; }
            public string AdditionalClaim { get; set; }
            public int BenefitYearBeginning { get; set; }
            public DateTime? DateMailedToEDD { get; set; }
            public DateTime? MailDate { get; set; }
            public DateTime? EffectiveDateOfClaim { get; set; }
            public DateTime? LastDateWorked { get; set; }
            public string Address { get; set; }
            public string ProtestDecision { get; set; }
            public DateTime? ReceivedDate { get; set; }
            public DateTime? DeadlineDate { get; set; }
            public string ClaimantStatus { get; set; }
            public string BYB { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zipcode { get; set; }
        }
        public class WagesAfterAppeal
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public DateTime? MailingDate { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string CaseNumber { get; set; }
            public DateTime? DeadLineDate { get; set; }
            public string PreparerName { get; set; }
            public string TelephoneNumber { get; set; }
            public string FaxNumber { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public string CreatedBy { get; set; }
            public Int64 ClaimId { get; set; }
            public string FormCode { get; set; }
            public string FormPath { get; set; }
            public Claim claim { get; set; }
        }
        public class MDDocument
        {

            public Int64 Id { get; set; }
            public string Channel { get; set; }
            public string DocumentType { get; set; }
            public string DocumentDescription { get; set; }
            public string DocumentName { get; set; }
            public string Stage { get; set; }
            public bool IsSharepointPushed { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public DateTime? ReceivedDate { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public Int64? ClaimId { get; set; }
            public Int64? DocumentId { get; set; }
        }
        public class SAP
        {
            public string EmployeeNumber { get; set; }
            public string SocialSecurityNumber { get; set; }
        }
        public class Employee
        {
            public string EmployeeNumber { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string SAPEmailAddress { get; set; }
        }
        public class FormIndexMap
        {
            public string Formcode { get; set; }
            public string FieldName { get; set; }
            public string PositionTopLeft { get; set; }
            public string PositionBottomRight { get; set; }
            public string Status { get; set; }
            public int LineNumber { get; set; }

        }
        public class ResponseToEmployer
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public DateTime? DateMailed { get; set; }
            public DateTime? BenefitYearBeganDate { get; set; }
            public DateTime? SeperationDate { get; set; }
            public DateTime? PostmarkDate { get; set; }
            public string FormCode { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public string FormPath { get; set; }
        }
        public class ClaimDetermination
        {
            public Int64 Id { get; set; }
            public string Decision { get; set; }
            public DateTime? MailedDate { get; set; }
            public DateTime? BenefitYearBegan { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string FieldOffice { get; set; }
            public string FormCode { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public string FormPath { get; set; }
            public Int64 ClaimId { get; set; }

        }
        public class ALJDecision
        {
            public Int64 Id { get; set; }
            public string PartiesAppearing { get; set; }
            public string Decision { get; set; }
            public string FormerlyCaseNumber { get; set; }
            public string CaseNumber { get; set; }
            public DateTime? MailDate { get; set; }
            public DateTime? BYBClaimDate { get; set; }
            public DateTime? ApplicationReopenDate { get; set; }
            public string ClaimantName { get; set; }
            public string EmployerInfo { get; set; }
            public string ALJName { get; set; }
            public string HearingPlace { get; set; }
            public DateTime? HearingDate { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public Int64 ClaimId { get; set; }
            public string FormCode { get; set; }
            public string FormPath { get; set; }

        }
        public class Hearing
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string CaseNumber { get; set; }
            public DateTime? MailDate { get; set; }
            public string HearingTime { get; set; }
            public string HearingPlace { get; set; }
            public bool AppellantType { get; set; }
            public string AppellantName { get; set; }
            public string Notes { get; set; }
            public string AdministrativeLawJudge { get; set; }
            public string EDDOffice { get; set; }
            public DateTime? HearingDate { get; set; }
            public Int64? IssuesList { get; set; }
            public string FormCode { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public Int64 ClaimId { get; set; }

        }
        public class Wages
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string OtherSSN { get; set; }
            public DateTime? ClaimDate { get; set; }
            public string FieldOfficePhoneNo { get; set; }
            public string FieldOfficeAddress { get; set; }
            public string Notes { get; set; }
            public DateTime? PostmarkedResponseDate { get; set; }
            public string WagesReport { get; set; }
            public string WagesQuarter1Date { get; set; }
            public string WagesQuarter2Date { get; set; }
            public string WagesQuarter3Date { get; set; }
            public string WagesQuarter4Date { get; set; }
            public string WagesQuarter1Amount { get; set; }
            public string WagesQuarter2Amount { get; set; }
            public string WagesQuarter3Amount { get; set; }
            public string WagesQuarter4Amount { get; set; }
            public string TotalWagesForEmployee { get; set; }
            public string TotalWagesForAllEmployees { get; set; }
            public string ClaimantWeeklyBenefitAmount { get; set; }
            public string BenefitChargeableReserveAccount { get; set; }
            public string FormCode { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public Int64 ClaimId { get; set; }
        }
        public class CUIABAcknowledgement
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public string ABCaseNumber { get; set; }
            public string Appellant { get; set; }
            public string ALJDecisionNumber { get; set; }
            public DateTime? DateMailed { get; set; }
            public string CreatedBy { get; set; }
            public string AccountNumber { get; set; }
            public string Address { get; set; }
            public string LAUSDAddress { get; set; }
            public string CUIABAddress { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public Int64 ClaimId { get; set; }
            public string FormCode { get; set; }
            public string FormPath { get; set; }

        }

        public class AdditionalInformation
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public DateTime? MailDate { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string ControlNumber { get; set; }
            public DateTime? ClaimEffectiveDate { get; set; }
            public string EmployerName { get; set; }
            public string PhoneNumber { get; set; }
            public string EmployerAddress { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public string CreatedBy { get; set; }
            public Int64 ClaimId { get; set; }
            public string FormCode { get; set; }
            public string FormPath { get; set; }
        }
        public class RequestForEmployeeData
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public DateTime? BYBClaimDate { get; set; }
            public string Notes { get; set; }
            public DateTime? Date { get; set; }
            public string UserCompletedBy { get; set; }
            public string UserCompletedDate { get; set; }
            public string UserTitle { get; set; }
            public string UserTelephoneNumber { get; set; }
            public string FormCode { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public Int64 ClaimId { get; set; }
            public Claim claim { get; set; }
        }

        public class BenefitAudit
        {
            public Int64 Id { get; set; }
            public string ClaimantName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public DateTime? MailDate { get; set; }
            public string Notes { get; set; }
            public string FormCode { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public Int64 ClaimId { get; set; }
            public Claim claim { get; set; }
        }
    }
}
