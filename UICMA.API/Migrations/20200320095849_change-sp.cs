using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class changesp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 192, DateTimeKind.Local).AddTicks(7096),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 961, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 225, DateTimeKind.Local).AddTicks(3852),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 999, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 230, DateTimeKind.Local).AddTicks(8018),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 5, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 118, DateTimeKind.Local).AddTicks(7661),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 880, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 131, DateTimeKind.Local).AddTicks(1559),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 892, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 33, DateTimeKind.Local).AddTicks(7827),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 777, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 32, DateTimeKind.Local).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 776, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 85, DateTimeKind.Local).AddTicks(7255),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 843, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 197, DateTimeKind.Local).AddTicks(9696),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 966, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 236, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 10, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 175, DateTimeKind.Local).AddTicks(4983),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 168, DateTimeKind.Local).AddTicks(5972),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 934, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 172, DateTimeKind.Local).AddTicks(6271),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 939, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 163, DateTimeKind.Local).AddTicks(11),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 928, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 76, DateTimeKind.Local).AddTicks(7343),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 828, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 128, DateTimeKind.Local).AddTicks(1164),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 889, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 184, DateTimeKind.Local).AddTicks(578),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 952, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 52, DateTimeKind.Local).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 797, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 55, DateTimeKind.Local).AddTicks(2455),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 800, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 93, DateTimeKind.Local).AddTicks(8229),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 854, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 176, DateTimeKind.Local).AddTicks(909),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 217, DateTimeKind.Local).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 989, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 243, DateTimeKind.Local).AddTicks(7762),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 18, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 114, DateTimeKind.Local).AddTicks(1636),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 873, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 49, DateTimeKind.Local).AddTicks(557),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 793, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 63, DateTimeKind.Local).AddTicks(3257),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 811, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 73, DateTimeKind.Local).AddTicks(1020),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 822, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 178, DateTimeKind.Local).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 945, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 81, DateTimeKind.Local).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 837, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 90, DateTimeKind.Local).AddTicks(9239),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 851, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 203, DateTimeKind.Local).AddTicks(538),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 971, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 188, DateTimeKind.Local).AddTicks(8763),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 957, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 208, DateTimeKind.Local).AddTicks(2632),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 977, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 109, DateTimeKind.Local).AddTicks(3695),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 866, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 124, DateTimeKind.Local).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 885, DateTimeKind.Local).AddTicks(4231));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 961, DateTimeKind.Local).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 192, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 999, DateTimeKind.Local).AddTicks(5009),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 225, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 5, DateTimeKind.Local).AddTicks(6062),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 230, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 880, DateTimeKind.Local).AddTicks(2756),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 118, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 892, DateTimeKind.Local).AddTicks(8278),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 131, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 777, DateTimeKind.Local).AddTicks(5831),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 33, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 776, DateTimeKind.Local).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 32, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 843, DateTimeKind.Local).AddTicks(4991),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 85, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 966, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 197, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 10, DateTimeKind.Local).AddTicks(5761),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 236, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 175, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 934, DateTimeKind.Local).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 168, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 939, DateTimeKind.Local).AddTicks(66),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 172, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 928, DateTimeKind.Local).AddTicks(1305),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 163, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 828, DateTimeKind.Local).AddTicks(1713),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 76, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 889, DateTimeKind.Local).AddTicks(6705),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 128, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 952, DateTimeKind.Local).AddTicks(2435),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 184, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 797, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 52, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 800, DateTimeKind.Local).AddTicks(8129),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 55, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 854, DateTimeKind.Local).AddTicks(9790),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 93, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 942, DateTimeKind.Local).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 176, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 989, DateTimeKind.Local).AddTicks(4545),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 217, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 9, 18, DateTimeKind.Local).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 243, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 873, DateTimeKind.Local).AddTicks(2938),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 114, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 793, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 49, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 811, DateTimeKind.Local).AddTicks(7566),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 63, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 822, DateTimeKind.Local).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 73, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 945, DateTimeKind.Local).AddTicks(8290),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 178, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 837, DateTimeKind.Local).AddTicks(619),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 81, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 851, DateTimeKind.Local).AddTicks(7403),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 90, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 971, DateTimeKind.Local).AddTicks(9638),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 203, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 957, DateTimeKind.Local).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 188, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 977, DateTimeKind.Local).AddTicks(2443),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 208, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 866, DateTimeKind.Local).AddTicks(6990),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 109, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 20, 15, 25, 8, 885, DateTimeKind.Local).AddTicks(4231),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 20, 15, 28, 49, 124, DateTimeKind.Local).AddTicks(923));
        }
    }
}
