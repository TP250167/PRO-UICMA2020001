using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class Alterbatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_ANNUAL",
                table: "RA_BATCH_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 567, DateTimeKind.Local).AddTicks(5645),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 196, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 616, DateTimeKind.Local).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 227, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 628, DateTimeKind.Local).AddTicks(3700),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 233, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 463, DateTimeKind.Local).AddTicks(3489),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 122, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 476, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 134, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 356, DateTimeKind.Local).AddTicks(1766),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 41, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 355, DateTimeKind.Local).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 40, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 417, DateTimeKind.Local).AddTicks(5340),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 91, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 578, DateTimeKind.Local).AddTicks(9830),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 201, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 633, DateTimeKind.Local).AddTicks(4069),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 238, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 541, DateTimeKind.Local).AddTicks(1105),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 176, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 529, DateTimeKind.Local).AddTicks(6427),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 169, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 534, DateTimeKind.Local).AddTicks(1255),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 174, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.AddColumn<bool>(
                name: "IS_ANNUAL",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 524, DateTimeKind.Local).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 165, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 406, DateTimeKind.Local).AddTicks(6559),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 82, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 473, DateTimeKind.Local).AddTicks(4088),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 131, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 558, DateTimeKind.Local).AddTicks(3700),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 187, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 376, DateTimeKind.Local).AddTicks(8048),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 58, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 379, DateTimeKind.Local).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 61, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 428, DateTimeKind.Local).AddTicks(3251),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 99, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 541, DateTimeKind.Local).AddTicks(8014),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 177, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 609, DateTimeKind.Local).AddTicks(3148),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 220, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 648, DateTimeKind.Local).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 245, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 458, DateTimeKind.Local).AddTicks(3914),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 117, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 372, DateTimeKind.Local).AddTicks(1501),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 54, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 389, DateTimeKind.Local).AddTicks(119),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 68, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 401, DateTimeKind.Local).AddTicks(2092),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 77, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 546, DateTimeKind.Local).AddTicks(5219),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 180, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 412, DateTimeKind.Local).AddTicks(5999),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 87, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 425, DateTimeKind.Local).AddTicks(824),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 97, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 583, DateTimeKind.Local).AddTicks(8503),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 206, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 563, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 192, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 594, DateTimeKind.Local).AddTicks(7620),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 211, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 452, DateTimeKind.Local).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 113, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 468, DateTimeKind.Local).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 127, DateTimeKind.Local).AddTicks(870));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_ANNUAL",
                table: "RA_RECIPIENT_RULE_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 196, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 567, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 227, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 616, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 233, DateTimeKind.Local).AddTicks(2281),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 628, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 122, DateTimeKind.Local).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 463, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 134, DateTimeKind.Local).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 476, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 41, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 356, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 40, DateTimeKind.Local).AddTicks(4277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 355, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 91, DateTimeKind.Local).AddTicks(3758),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 417, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 201, DateTimeKind.Local).AddTicks(7268),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 578, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 238, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 633, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 176, DateTimeKind.Local).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 541, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 169, DateTimeKind.Local).AddTicks(6344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 529, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 174, DateTimeKind.Local).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 534, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 165, DateTimeKind.Local).AddTicks(221),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 524, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.AddColumn<bool>(
                name: "IS_ANNUAL",
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
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 406, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 131, DateTimeKind.Local).AddTicks(5655),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 473, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 187, DateTimeKind.Local).AddTicks(7976),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 558, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 58, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 376, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 61, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 379, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 99, DateTimeKind.Local).AddTicks(9828),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 428, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 177, DateTimeKind.Local).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 541, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 220, DateTimeKind.Local).AddTicks(3438),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 609, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 245, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 648, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 117, DateTimeKind.Local).AddTicks(9794),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 458, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 54, DateTimeKind.Local).AddTicks(8872),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 372, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 68, DateTimeKind.Local).AddTicks(7550),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 389, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 77, DateTimeKind.Local).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 401, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 180, DateTimeKind.Local).AddTicks(8662),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 546, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 87, DateTimeKind.Local).AddTicks(2564),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 412, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 97, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 425, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 206, DateTimeKind.Local).AddTicks(4802),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 583, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 192, DateTimeKind.Local).AddTicks(5536),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 563, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 211, DateTimeKind.Local).AddTicks(2807),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 594, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 113, DateTimeKind.Local).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 452, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 127, DateTimeKind.Local).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 59, 55, 468, DateTimeKind.Local).AddTicks(9988));
        }
    }
}
