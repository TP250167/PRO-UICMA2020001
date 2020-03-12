using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.Additional_Information;
using UICMA.Domain.Entities.Additional_InformationMap;
using UICMA.Domain.Entities.ALJ_Decision;
using UICMA.Domain.Entities.ALJ_DecisionMap;
using UICMA.Domain.Entities.Associated_Documents;
using UICMA.Domain.Entities.Benefit_Audit;
using UICMA.Domain.Entities.Benefit_AuditMap;
using UICMA.Domain.Entities.Benefit_Charge;
using UICMA.Domain.Entities.Benefit_Charge_Claimant_DetailMap;
using UICMA.Domain.Entities.Benefit_Charge_ClaimantDetail;
using UICMA.Domain.Entities.Benefit_ChargeMap;
using UICMA.Domain.Entities.Claim_Appeal;
using UICMA.Domain.Entities.Claim_AppealMap;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Domain.Entities.Claim_DeterminationMap;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Domain.Entities.Claim_InterviewMap;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Domain.Entities.Claim_ResponseMap;
using UICMA.Domain.Entities.ClaimExceptionMap;
using UICMA.Domain.Entities.ClaimExceptions;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;
using UICMA.Domain.Entities.CUIAB_AcknowledgementMap;
using UICMA.Domain.Entities.Determination_Appeal;
using UICMA.Domain.Entities.Determination_AppealMap;
using UICMA.Domain.Entities.EmployeeMap;
using UICMA.Domain.Entities.Employees;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Domain.Entities.Form_Document_Map;
using UICMA.Domain.Entities.HearingMap;
using UICMA.Domain.Entities.Hearings;
using UICMA.Domain.Entities.Issues_List;
using UICMA.Domain.Entities.Issues_ListMap;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_DocumentMap;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Domain.Entities.MD_FormMap;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.New_ClaimMap;
using UICMA.Domain.Entities.NoticeOfWages;
using UICMA.Domain.Entities.NotificationMap;
using UICMA.Domain.Entities.Notifications;
using UICMA.Domain.Entities.Questions;
using UICMA.Domain.Entities.QuestionsMap;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RAAssociatedDocumentMap;
using UICMA.Domain.Entities.RAAssociatedDocuments;
using UICMA.Domain.Entities.RABatchMap;
using UICMA.Domain.Entities.RABatchRecipientMap;
using UICMA.Domain.Entities.RABatchRecipientRuleMap;
using UICMA.Domain.Entities.RABatchRecipientRules;
using UICMA.Domain.Entities.RABatchRecipients;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RABatchScheduleMap;
using UICMA.Domain.Entities.RABatchSchedules;
using UICMA.Domain.Entities.RABatchTemplateMap;
using UICMA.Domain.Entities.RABatchTemplates;
using UICMA.Domain.Entities.RARecipientMap;
using UICMA.Domain.Entities.RARecipientRuleMap;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Domain.Entities.RARecipients;
using UICMA.Domain.Entities.RAScheduleMap;
using UICMA.Domain.Entities.RASchedules;
using UICMA.Domain.Entities.Request_For_EmployeeData;
using UICMA.Domain.Entities.Request_For_EmployeeDataMap;
using UICMA.Domain.Entities.Request_To_Reopen;
using UICMA.Domain.Entities.Request_To_ReopenMap;
using UICMA.Domain.Entities.Response_to_Employer;
using UICMA.Domain.Entities.Response_to_EmployerMap;
using UICMA.Domain.Entities.TemplateMap;
using UICMA.Domain.Entities.Templates;
using UICMA.Domain.Entities.Wages_After_Appeal;
using UICMA.Domain.Entities.Wages_After_AppealMap;
using UICMA.Domain.Entities.Wages_Appeal;
using UICMA.Domain.Entities.Wages_AppealMap;
using UICMA.Domain.Entities.WagesMap;
using UICMA.Domain.Entities.WritMap;
using UICMA.Domain.Entities.Writs;

namespace UICMA.Repository
{
    public class UICMAContext:DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<MDDocument> MDDocuments { get; set; }
        public DbSet<MDForm> MDForms { get; set; }
        public DbSet<ClaimResponse> ClaimResponses { get; set; }
        public DbSet<AssociatedDocuments> associatedDocuments { get; set; }
        public DbSet<ClaimInterview> ClaimInterviews { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ClaimDetermination> ClaimDeterminations { get; set; }
        public DbSet<ResponseToEmployer> ResponseToEmployers { get; set; }
        public DbSet<ClaimAppeal> ClaimAppeals { get; set; }
        public DbSet<IssuesList> IssuesLists { get; set; }
        public DbSet<ALJDecision> ALJDecisions { get; set; }
        public DbSet<CUIABAcknowledgement> CUIABAcknowledgements { get; set; }
        public DbSet<WagesAfterAppeal> WagesAfterAppeals { get; set; }
        public DbSet<AdditionalInformation> AdditionalInformations { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<RABatchRecipientRule> RABatchRecipientRules { get; set; }
        public DbSet<FormDocument> FormDocument { get; set; }
        public DbSet<ClaimException> ClaimExceptions { get; set; }
        public DbSet<Hearing> Hearings { get; set; }
        public DbSet<BenefitAudit> BenefitAudits { get; set; }
        public DbSet<Writ> Writs { get; set; }
        public DbSet<RequestToReopen> RequestToReopens { get; set; }
        public DbSet<Employee> Employee { get; set; }
        
        public DbSet<RABatchView> RABatch { get; set; }
        public DbSet<RARecipient> RARecipient { get; set; }
        public DbSet<RABatchViewModel> spRaBatchDetail { get; set; }
        public DbSet<RANotificationViewModel> vwRaNotificationList { get; set; }


        public UICMAContext(DbContextOptions<UICMAContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
            new ScheduleMap(modelBuilder.Entity<Schedule>());
            new UserMap(modelBuilder.Entity<User>());
            new AttendeeMap(modelBuilder.Entity<Attendee>());
            new ClaimMap(modelBuilder.Entity<Claim>());
            new MDFormMap(modelBuilder.Entity<MDForm>());
            new MDDocumentMap(modelBuilder.Entity<MDDocument>());
            new ClaimResponseMap(modelBuilder.Entity<ClaimResponse>());
            new ClaimInterviewMap(modelBuilder.Entity<ClaimInterview>());
            new QuestionsMap(modelBuilder.Entity<Question>());
            new ClaimDeterminationMap(modelBuilder.Entity<ClaimDetermination>());
            new ResponseToEmployerMap(modelBuilder.Entity<ResponseToEmployer>());
            new ClaimAppealMap(modelBuilder.Entity<ClaimAppeal>());
            new IssuesListMap(modelBuilder.Entity<IssuesList>());

            modelBuilder.Entity<AssociatedDocuments>().ToTable("ASSOCIATED_DOCUMENTS_TBL")
             .HasKey(t => new { t.FormId, t.DocumentId });

            modelBuilder.Entity<AssociatedDocuments>()
                .HasOne(pt => pt.MDForms)
                .WithMany(p => p.AssociatedDocuments)
                .HasForeignKey(pt => pt.FormId);

            modelBuilder.Entity<AssociatedDocuments>()
                .HasOne(pt => pt.MDDocument)
                .WithMany(t => t.AssociatedDocuments)
                .HasForeignKey(pt => pt.DocumentId);

            new FormDocumentMap(modelBuilder.Entity<FormDocument>());
            new ALJDecisionMap(modelBuilder.Entity<ALJDecision>());
            new CUIABAcknowledgementMap(modelBuilder.Entity<CUIABAcknowledgement>());
            new WagesAfterAppealMap(modelBuilder.Entity<WagesAfterAppeal>());
            new AdditionalInformationMap(modelBuilder.Entity<AdditionalInformation>());
            new NotificationMap(modelBuilder.Entity<Notification>());
            new TemplateMap(modelBuilder.Entity<Template>());
            new RABatchRecipientRuleMap(modelBuilder.Entity<RABatchRecipientRule>());
            new RAAssociatedDocumentMap(modelBuilder.Entity<RAAssociatedDocument>());
            new RABatchRecipientMap(modelBuilder.Entity<RABatchRecipient>());
            new RABatchScheduleMap(modelBuilder.Entity<RABatchSchedule>());
            new RABatchTemplateMap(modelBuilder.Entity<RABatchTemplate>());
            new EmployeeMap(modelBuilder.Entity<Employee>());
            new RABatchMap(modelBuilder.Entity<RABatchView>());
            new RARecipientMap(modelBuilder.Entity<RARecipient>());
            new RARecipientRuleMap(modelBuilder.Entity<RARecipientRule>());
            new RAScheduleMap(modelBuilder.Entity<RASchedule>());
            new FormDocumentMap(modelBuilder.Entity<FormDocument>());
            new ClaimExceptionMap(modelBuilder.Entity<ClaimException>());
            new HearingMap(modelBuilder.Entity<Hearing>());
            new BenefitAuditMap(modelBuilder.Entity<BenefitAudit>());
            new WritMap(modelBuilder.Entity<Writ>());
            new RequestToReopenMap(modelBuilder.Entity<RequestToReopen>());
            new BenefitChargeMap(modelBuilder.Entity<BenefitCharge>());
            new BenefitChargeClaimantDetailMap(modelBuilder.Entity<BenefitChargeClaimantDetail>());
            new DeterminationAppealMap(modelBuilder.Entity<DeterminationAppeal>());
            new WagesMap(modelBuilder.Entity<Wages>());
            new WagesAppealMap(modelBuilder.Entity<WagesAppeal>());
            new RequestForEmployeeDataMap(modelBuilder.Entity<RequestForEmployeeData>());
        }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
