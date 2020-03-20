using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class changespnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORM_DOCUMENT_MAP_TBL_MD_DOCUMENT_TBL_DOCUMENT_ID",
                table: "FORM_DOCUMENT_MAP_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_FORM_DOCUMENT_MAP_TBL_MD_FORM_TBL_FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL");


            migrationBuilder.DropIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_DOCUMENT_ID",
                table: "FORM_DOCUMENT_MAP_TBL");

            migrationBuilder.DropIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL");

            migrationBuilder.DropColumn(
                name: "FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL");

         

            migrationBuilder.RenameColumn(
                name: "EMPLOYEE_NAME",
                table: "RA_RECIPIENT_TBL",
                newName: "LAST_NAME");

            migrationBuilder.RenameColumn(
                name: "UPLOAD_FILE_NAME",
                table: "FORM_DOCUMENT_MAP_TBL",
                newName: "STAGE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 961, DateTimeKind.Local).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 448, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 999, DateTimeKind.Local).AddTicks(5009),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 490, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 5, DateTimeKind.Local).AddTicks(6062),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 500, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 880, DateTimeKind.Local).AddTicks(2756),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 353, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 892, DateTimeKind.Local).AddTicks(8278),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 367, DateTimeKind.Local).AddTicks(1711));


          

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 777, DateTimeKind.Local).AddTicks(5831),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 261, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 776, DateTimeKind.Local).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 260, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 843, DateTimeKind.Local).AddTicks(4991),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 316, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 966, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 455, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 10, DateTimeKind.Local).AddTicks(5761),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 506, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 425, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 934, DateTimeKind.Local).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 416, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.AddColumn<string>(
                name: "FIRST_NAME",
                table: "RA_RECIPIENT_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JOB_CODE",
                table: "RA_RECIPIENT_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JOB_TITLE",
                table: "RA_RECIPIENT_TBL",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 939, DateTimeKind.Local).AddTicks(66),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 421, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.AddColumn<bool>(
                name: "IS_ANNUAL",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 928, DateTimeKind.Local).AddTicks(1305),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 410, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 828, DateTimeKind.Local).AddTicks(1713),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 305, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 889, DateTimeKind.Local).AddTicks(6705),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 363, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 952, DateTimeKind.Local).AddTicks(2435),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 438, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 797, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 279, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 800, DateTimeKind.Local).AddTicks(8129),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 282, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 854, DateTimeKind.Local).AddTicks(9790),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 325, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 426, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.AddColumn<string>(
                name: "DOCUMENT_NAME",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DOCUMENT_TYPE",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IS_SHAREPOINT_PUSHED",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "JOB_CODE",
                table: "EMPLOYEE_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JOB_TITLE",
                table: "EMPLOYEE_TBL",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 989, DateTimeKind.Local).AddTicks(4545),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 479, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 18, DateTimeKind.Local).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 520, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 873, DateTimeKind.Local).AddTicks(2938),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 348, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 793, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 275, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 811, DateTimeKind.Local).AddTicks(7566),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 291, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 822, DateTimeKind.Local).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 301, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 945, DateTimeKind.Local).AddTicks(8290),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 430, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.AddColumn<int>(
                name: "BENEFIT_YEAR_BEGINNING",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "STATUS",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 837, DateTimeKind.Local).AddTicks(619),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 310, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 851, DateTimeKind.Local).AddTicks(7403),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 322, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 971, DateTimeKind.Local).AddTicks(9638),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 461, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 957, DateTimeKind.Local).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 444, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 977, DateTimeKind.Local).AddTicks(2443),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 468, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 866, DateTimeKind.Local).AddTicks(6990),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 342, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 885, DateTimeKind.Local).AddTicks(4231),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 358, DateTimeKind.Local).AddTicks(6612));

       

            migrationBuilder.CreateIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_CLAIM_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "CLAIM_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FORM_DOCUMENT_MAP_TBL_CLAIM_TBL_CLAIM_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "CLAIM_ID",
                principalTable: "CLAIM_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORM_DOCUMENT_MAP_TBL_CLAIM_TBL_CLAIM_ID",
                table: "FORM_DOCUMENT_MAP_TBL");

         


            migrationBuilder.DropIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_CLAIM_ID",
                table: "FORM_DOCUMENT_MAP_TBL");

           

            migrationBuilder.DropColumn(
                name: "FIRST_NAME",
                table: "RA_RECIPIENT_TBL");

            migrationBuilder.DropColumn(
                name: "JOB_CODE",
                table: "RA_RECIPIENT_TBL");

            migrationBuilder.DropColumn(
                name: "JOB_TITLE",
                table: "RA_RECIPIENT_TBL");

            migrationBuilder.DropColumn(
                name: "IS_ANNUAL",
                table: "RA_RECIPIENT_RULE_TBL");

            migrationBuilder.DropColumn(
                name: "DOCUMENT_NAME",
                table: "FORM_DOCUMENT_MAP_TBL");

            migrationBuilder.DropColumn(
                name: "DOCUMENT_TYPE",
                table: "FORM_DOCUMENT_MAP_TBL");

            migrationBuilder.DropColumn(
                name: "IS_SHAREPOINT_PUSHED",
                table: "FORM_DOCUMENT_MAP_TBL");

            migrationBuilder.DropColumn(
                name: "JOB_CODE",
                table: "EMPLOYEE_TBL");

            migrationBuilder.DropColumn(
                name: "JOB_TITLE",
                table: "EMPLOYEE_TBL");

            migrationBuilder.DropColumn(
                name: "BENEFIT_YEAR_BEGINNING",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "CLAIM_EXCEPTION_TBL");

         

           

            migrationBuilder.RenameColumn(
                name: "LAST_NAME",
                table: "RA_RECIPIENT_TBL",
                newName: "EMPLOYEE_NAME");

            migrationBuilder.RenameColumn(
                name: "STAGE",
                table: "FORM_DOCUMENT_MAP_TBL",
                newName: "UPLOAD_FILE_NAME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 448, DateTimeKind.Local).AddTicks(6436),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 961, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 490, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 999, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 500, DateTimeKind.Local).AddTicks(2768),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 5, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 353, DateTimeKind.Local).AddTicks(4152),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 880, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 367, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 892, DateTimeKind.Local).AddTicks(8278));

        

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 261, DateTimeKind.Local).AddTicks(7108),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 777, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 260, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 776, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 316, DateTimeKind.Local).AddTicks(5409),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 843, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 455, DateTimeKind.Local).AddTicks(1068),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 966, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 506, DateTimeKind.Local).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 10, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 425, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 416, DateTimeKind.Local).AddTicks(863),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 934, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 421, DateTimeKind.Local).AddTicks(2091),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 939, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 410, DateTimeKind.Local).AddTicks(8708),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 928, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 305, DateTimeKind.Local).AddTicks(4114),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 828, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 363, DateTimeKind.Local).AddTicks(2199),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 889, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 438, DateTimeKind.Local).AddTicks(2100),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 952, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 279, DateTimeKind.Local).AddTicks(7671),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 797, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 282, DateTimeKind.Local).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 800, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 325, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 854, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 426, DateTimeKind.Local).AddTicks(2523),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.AddColumn<long>(
                name: "FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 479, DateTimeKind.Local).AddTicks(2572),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 989, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 520, DateTimeKind.Local).AddTicks(897),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 18, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 348, DateTimeKind.Local).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 873, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 275, DateTimeKind.Local).AddTicks(9528),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 793, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 291, DateTimeKind.Local).AddTicks(4861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 811, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 301, DateTimeKind.Local).AddTicks(3892),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 822, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 430, DateTimeKind.Local).AddTicks(5551),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 945, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 310, DateTimeKind.Local).AddTicks(7703),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 837, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 322, DateTimeKind.Local).AddTicks(1475),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 851, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 461, DateTimeKind.Local).AddTicks(9578),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 971, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 444, DateTimeKind.Local).AddTicks(826),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 957, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 468, DateTimeKind.Local).AddTicks(5436),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 977, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 342, DateTimeKind.Local).AddTicks(7356),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 866, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 358, DateTimeKind.Local).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 885, DateTimeKind.Local).AddTicks(4231));



            migrationBuilder.CreateIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_DOCUMENT_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "DOCUMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "FORM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FORM_DOCUMENT_MAP_TBL_MD_DOCUMENT_TBL_DOCUMENT_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "DOCUMENT_ID",
                principalTable: "MD_DOCUMENT_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FORM_DOCUMENT_MAP_TBL_MD_FORM_TBL_FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "FORM_ID",
                principalTable: "MD_FORM_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
