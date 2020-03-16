using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class alterbatchtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 196, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 269, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 227, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 300, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 233, DateTimeKind.Local).AddTicks(2281),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 305, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 122, DateTimeKind.Local).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 196, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 134, DateTimeKind.Local).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 208, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 41, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 116, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 40, DateTimeKind.Local).AddTicks(4277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 115, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 91, DateTimeKind.Local).AddTicks(3758),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 166, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 201, DateTimeKind.Local).AddTicks(7268),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 274, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 238, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 310, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 176, DateTimeKind.Local).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 169, DateTimeKind.Local).AddTicks(6344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 242, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 174, DateTimeKind.Local).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 245, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 165, DateTimeKind.Local).AddTicks(221),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 237, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.AddColumn<bool>(
                name: "IS_ANNUAL",
                table: "RA_BATCH_TBL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IS_CUSTOM",
                table: "RA_BATCH_TBL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 82, DateTimeKind.Local).AddTicks(81),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 154, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 131, DateTimeKind.Local).AddTicks(5655),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 205, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 187, DateTimeKind.Local).AddTicks(7976),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 259, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 58, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 132, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 61, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 135, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 99, DateTimeKind.Local).AddTicks(9828),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 175, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 177, DateTimeKind.Local).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 220, DateTimeKind.Local).AddTicks(3438),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 293, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 245, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 318, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 117, DateTimeKind.Local).AddTicks(9794),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 192, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 54, DateTimeKind.Local).AddTicks(8872),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 129, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 68, DateTimeKind.Local).AddTicks(7550),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 142, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 77, DateTimeKind.Local).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 150, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 180, DateTimeKind.Local).AddTicks(8662),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 252, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 87, DateTimeKind.Local).AddTicks(2564),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 161, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 97, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 172, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 206, DateTimeKind.Local).AddTicks(4802),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 279, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 192, DateTimeKind.Local).AddTicks(5536),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 264, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 211, DateTimeKind.Local).AddTicks(2807),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 283, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 113, DateTimeKind.Local).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 188, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 127, DateTimeKind.Local).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 201, DateTimeKind.Local).AddTicks(2679));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_ANNUAL",
                table: "RA_BATCH_TBL");

            migrationBuilder.DropColumn(
                name: "IS_CUSTOM",
                table: "RA_BATCH_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 269, DateTimeKind.Local).AddTicks(856),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 196, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 300, DateTimeKind.Local).AddTicks(5274),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 227, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 305, DateTimeKind.Local).AddTicks(7292),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 233, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 196, DateTimeKind.Local).AddTicks(9965),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 122, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 208, DateTimeKind.Local).AddTicks(2102),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 134, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 116, DateTimeKind.Local).AddTicks(2553),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 41, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 115, DateTimeKind.Local).AddTicks(3604),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 40, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 166, DateTimeKind.Local).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 91, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 274, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 201, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 310, DateTimeKind.Local).AddTicks(4872),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 238, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(1926),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 176, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 242, DateTimeKind.Local).AddTicks(2228),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 169, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 245, DateTimeKind.Local).AddTicks(6942),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 174, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 237, DateTimeKind.Local).AddTicks(7010),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 165, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 154, DateTimeKind.Local).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 82, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 205, DateTimeKind.Local).AddTicks(1360),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 131, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 259, DateTimeKind.Local).AddTicks(2899),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 187, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 132, DateTimeKind.Local).AddTicks(7070),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 58, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 135, DateTimeKind.Local).AddTicks(1566),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 61, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 175, DateTimeKind.Local).AddTicks(4169),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 99, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(7862),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 177, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 293, DateTimeKind.Local).AddTicks(7395),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 220, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 318, DateTimeKind.Local).AddTicks(457),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 245, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 192, DateTimeKind.Local).AddTicks(6659),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 117, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 129, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 54, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 142, DateTimeKind.Local).AddTicks(8681),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 68, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 150, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 77, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 252, DateTimeKind.Local).AddTicks(1684),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 180, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 161, DateTimeKind.Local).AddTicks(6079),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 87, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 172, DateTimeKind.Local).AddTicks(4199),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 97, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 279, DateTimeKind.Local).AddTicks(2696),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 206, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 264, DateTimeKind.Local).AddTicks(1524),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 192, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 283, DateTimeKind.Local).AddTicks(9662),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 211, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 188, DateTimeKind.Local).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 113, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 201, DateTimeKind.Local).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 127, DateTimeKind.Local).AddTicks(870));
        }
    }
}
