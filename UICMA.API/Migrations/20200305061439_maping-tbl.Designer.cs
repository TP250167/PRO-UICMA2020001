﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UICMA.Repository;

namespace UICMA.API.Migrations
{
    [DbContext(typeof(UICMAContext))]
    [Migration("20200305061439_maping-tbl")]
    partial class mapingtbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UICMA.Domain.Entities.Associated_Documents.AssociatedDocuments", b =>
                {
                    b.Property<long>("FormId");

                    b.Property<long>("DocumentId");

                    b.HasKey("FormId", "DocumentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("ASSOCIATED_DOCUMENTS_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Attendee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ScheduleId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("UserId");

                    b.ToTable("ATTENDEE_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Claim_Response.ClaimResponse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("ADDRESS");

                    b.Property<DateTime?>("BYBClaimDate")
                        .HasColumnName("BYB_CLAIM_DATE");

                    b.Property<string>("City")
                        .HasColumnName("CITY");

                    b.Property<long>("ClaimId")
                        .HasColumnName("CLAIM_ID");

                    b.Property<string>("ClaimantName")
                        .HasColumnName("CLAIMANT_NAME");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnName("CREATED_ON");

                    b.Property<DateTime?>("Date")
                        .HasColumnName("DATE");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnName("DUE_DATE");

                    b.Property<bool>("EEContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EE_CONTRACT")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("EffectiveDateOfClaim")
                        .HasColumnName("EFFECTIVE_DATE_OF_CLAIM");

                    b.Property<string>("FormCode")
                        .HasColumnName("FORM_CODE");

                    b.Property<long?>("IssuesList")
                        .HasColumnName("ISSUES_LIST");

                    b.Property<DateTime?>("LAUSDMailDate")
                        .HasColumnName("LAUSD_MAIL_DATE");

                    b.Property<string>("LAUSDResponse")
                        .HasColumnName("LAUSD_RESPONSE");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MODIFIED_ON")
                        .HasDefaultValue(new DateTime(2020, 3, 5, 11, 44, 39, 601, DateTimeKind.Local).AddTicks(3114));

                    b.Property<bool>("OfferLetter")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OFFER_LETTER")
                        .HasDefaultValue(false);

                    b.Property<bool>("Other")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OTHER")
                        .HasDefaultValue(false);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("PHONE_NUMBER");

                    b.Property<bool>("ProtestPage")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PROTEST_PAGE")
                        .HasDefaultValue(false);

                    b.Property<bool>("RALetter")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RA_LETTER")
                        .HasDefaultValue(false);

                    b.Property<string>("RepresentativeName")
                        .HasColumnName("REPRESENTATIVE_NAME");

                    b.Property<string>("Signature")
                        .HasColumnName("SIGNATURE");

                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnName("SOCIAL_SECURITY_NUMBER");

                    b.Property<string>("State")
                        .HasColumnName("STATE");

                    b.Property<bool>("StatementOfCharges")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("STATEMENT_OF_CHARGES")
                        .HasDefaultValue(false);

                    b.Property<bool>("SubCalender")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SUB_CALENDER")
                        .HasDefaultValue(false);

                    b.Property<bool>("TimeWageReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TIME_WAGE_REPORT")
                        .HasDefaultValue(false);

                    b.Property<string>("Title")
                        .HasColumnName("TITLE");

                    b.Property<bool>("WarningLetters")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("WARNING_LETTERS")
                        .HasDefaultValue(false);

                    b.Property<string>("Zipcode")
                        .HasColumnName("ZIPCODE");

                    b.HasKey("Id")
                        .HasName("CLAIM_RESPONSE_ID");

                    b.HasIndex("ClaimId")
                        .IsUnique();

                    b.ToTable("CLAIM_RESPONSE_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.MD_Document.MDDocument", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnName("CREATED_ON");

                    b.Property<string>("DocumentDescription")
                        .HasColumnName("DOCUMENT_DESCRIPTION");

                    b.Property<string>("DocumentName")
                        .HasColumnName("DOCUMENT_NAME");

                    b.Property<string>("DocumentStatus")
                        .HasColumnName("DOCUMENT_STATUS");

                    b.Property<bool>("IsMandatory")
                        .HasColumnName("IS_MANDATORY");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MODIFIED_ON")
                        .HasDefaultValue(new DateTime(2020, 3, 5, 11, 44, 39, 593, DateTimeKind.Local).AddTicks(9639));

                    b.HasKey("Id")
                        .HasName("MD_DOCUMENT_ID");

                    b.ToTable("MD_DOCUMENT_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.MD_Form.MDForm", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnName("CREATED_ON");

                    b.Property<string>("FormCode")
                        .HasColumnName("FORM_CODE");

                    b.Property<string>("FormName")
                        .HasColumnName("FORM_NAME");

                    b.Property<string>("FormStatus")
                        .HasColumnName("FORM_STATUS");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MODIFIED_ON")
                        .HasDefaultValue(new DateTime(2020, 3, 5, 11, 44, 39, 591, DateTimeKind.Local).AddTicks(3803));

                    b.HasKey("Id")
                        .HasName("MD_FORM_ID");

                    b.ToTable("MD_FORM_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.New_Claim.Claim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalClaim")
                        .HasColumnName("ADDITIONAL_CLAIM");

                    b.Property<int>("BenefitYearBeginning")
                        .HasColumnName("BENEFIT_YEAR_BEGINNING");

                    b.Property<string>("ClaimantName")
                        .HasColumnName("CLAIMANT_NAME");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnName("CREATED_ON");

                    b.Property<string>("CurrentStage")
                        .HasColumnName("CURRENT_STAGE");

                    b.Property<DateTime?>("DateMailedToEDD")
                        .HasColumnName("DATE_MAILED_TO_EDD");

                    b.Property<DateTime?>("EffectiveDateOfClaim")
                        .HasColumnName("EFFECTIVE_DATE_OF_CLAIM");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnName("EMPLOYEE_NUMBER");

                    b.Property<string>("Gender")
                        .HasColumnName("GENDER");

                    b.Property<DateTime?>("LastDateWorked")
                        .HasColumnName("LAST_DATE_WORKED");

                    b.Property<DateTime?>("MailDate")
                        .HasColumnName("MAIL_DATE");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("MODIFIED_BY");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MODIFIED_ON")
                        .HasDefaultValue(new DateTime(2020, 3, 5, 11, 44, 39, 587, DateTimeKind.Local).AddTicks(7464));

                    b.Property<string>("NewClaim")
                        .HasColumnName("NEW_CLAIM");

                    b.Property<string>("ReasonForSeparation")
                        .HasColumnName("REASON_FOR_SEPARATION");

                    b.Property<string>("RequestNumber")
                        .HasColumnName("REQUEST_NUMBER");

                    b.Property<string>("RequestTitle")
                        .HasColumnName("REQUEST_TITLE");

                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnName("SOCIAL_SECURITY_NUMBER");

                    b.Property<string>("Type")
                        .HasColumnName("TYPE");

                    b.HasKey("Id")
                        .HasName("CLAIM_ID");

                    b.ToTable("CLAIM_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Schedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 3, 5, 11, 44, 39, 574, DateTimeKind.Local).AddTicks(5023));

                    b.Property<long?>("CreatorId");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 3, 5, 11, 44, 39, 575, DateTimeKind.Local).AddTicks(7825));

                    b.Property<long?>("ModifierId");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.Property<DateTime>("TimeEnd");

                    b.Property<DateTime>("TimeStart");

                    b.Property<string>("Title");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(3);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("SCHEDULE_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Profession");

                    b.HasKey("Id");

                    b.ToTable("USER_TBL");
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Associated_Documents.AssociatedDocuments", b =>
                {
                    b.HasOne("UICMA.Domain.Entities.MD_Document.MDDocument", "MDDocument")
                        .WithMany("AssociatedDocuments")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("UICMA.Domain.Entities.MD_Form.MDForm", "MDForms")
                        .WithMany("AssociatedDocuments")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Attendee", b =>
                {
                    b.HasOne("UICMA.Domain.Entities.Schedule", "Schedule")
                        .WithMany("Attendees")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("UICMA.Domain.Entities.User", "User")
                        .WithMany("SchedulesAttended")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Claim_Response.ClaimResponse", b =>
                {
                    b.HasOne("UICMA.Domain.Entities.New_Claim.Claim", "claim")
                        .WithOne("claimResponse")
                        .HasForeignKey("UICMA.Domain.Entities.Claim_Response.ClaimResponse", "ClaimId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("UICMA.Domain.Entities.Schedule", b =>
                {
                    b.HasOne("UICMA.Domain.Entities.User", "Creator")
                        .WithMany("SchedulesCreated")
                        .HasForeignKey("CreatorId");

                    b.HasOne("UICMA.Domain.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");
                });
#pragma warning restore 612, 618
        }
    }
}