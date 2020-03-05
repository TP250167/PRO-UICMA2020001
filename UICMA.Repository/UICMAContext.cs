using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.Associated_Documents;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Domain.Entities.Claim_DeterminationMap;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Domain.Entities.Claim_InterviewMap;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Domain.Entities.Claim_ResponseMap;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_DocumentMap;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Domain.Entities.MD_FormMap;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.New_ClaimMap;
using UICMA.Domain.Entities.Questions;
using UICMA.Domain.Entities.QuestionsMap;
using UICMA.Domain.Entities.Response_to_Employer;
using UICMA.Domain.Entities.Response_to_EmployerMap;

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

            new ResponseToEmployerMap(modelBuilder.Entity<ResponseToEmployer>());
        }
    }
}
