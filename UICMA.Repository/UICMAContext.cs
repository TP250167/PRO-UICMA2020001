using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.Associated_Documents;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Domain.Entities.Claim_ResponseMap;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_DocumentMap;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Domain.Entities.MD_FormMap;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.New_ClaimMap;

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

            //modelBuilder.Entity<UserSubscription>()
            // .HasKey(t => new { t.UserId, t.SubscriptionId });

            //modelBuilder.Entity<UserSubscription>()
            //    .HasOne(pt => pt.User)
            //    .WithMany(p => p.UserSubscription)
            //    .HasForeignKey(pt => pt.UserId);

            //modelBuilder.Entity<UserSubscription>()
            //    .HasOne(pt => pt.Subscription)
            //    .WithMany(t => t.UserSubscription)
            //    .HasForeignKey(pt => pt.SubscriptionId);


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
        }
    }
}
