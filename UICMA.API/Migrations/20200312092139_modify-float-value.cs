using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class modifyfloatvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 126, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 799, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 977, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 722, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 1, DateTimeKind.Local).AddTicks(3971),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 733, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 860, DateTimeKind.Local).AddTicks(4822),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 649, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 859, DateTimeKind.Local).AddTicks(138),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 648, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 922, DateTimeKind.Local).AddTicks(118),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 693, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 135, DateTimeKind.Local).AddTicks(4144),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 804, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 90, DateTimeKind.Local).AddTicks(9836),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 78, DateTimeKind.Local).AddTicks(4717),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 772, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 86, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 777, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 67, DateTimeKind.Local).AddTicks(4134),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 767, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 910, DateTimeKind.Local).AddTicks(8331),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 684, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 995, DateTimeKind.Local).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 730, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 111, DateTimeKind.Local).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 791, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 884, DateTimeKind.Local).AddTicks(873),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 663, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 887, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 665, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 931, DateTimeKind.Local).AddTicks(7955),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 701, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 92, DateTimeKind.Local).AddTicks(1413),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 968, DateTimeKind.Local).AddTicks(1647),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 718, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 878, DateTimeKind.Local).AddTicks(8843),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 660, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 895, DateTimeKind.Local).AddTicks(9386),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 673, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 906, DateTimeKind.Local).AddTicks(1915),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 681, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 98, DateTimeKind.Local).AddTicks(2141),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 784, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 917, DateTimeKind.Local).AddTicks(4578),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 690, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 928, DateTimeKind.Local).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 698, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 145, DateTimeKind.Local).AddTicks(782),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 809, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 118, DateTimeKind.Local).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 795, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 153, DateTimeKind.Local).AddTicks(3625),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 814, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.AlterColumn<decimal>(
                name: "EMPLOYER_CHARGE",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                type: "decimal(16,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 959, DateTimeKind.Local).AddTicks(4474),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 713, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 987, DateTimeKind.Local).AddTicks(3066),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 726, DateTimeKind.Local).AddTicks(8269));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 799, DateTimeKind.Local).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 126, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 722, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 977, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 733, DateTimeKind.Local).AddTicks(3036),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 1, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 649, DateTimeKind.Local).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 860, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 648, DateTimeKind.Local).AddTicks(1476),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 859, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 693, DateTimeKind.Local).AddTicks(8203),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 922, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 804, DateTimeKind.Local).AddTicks(8219),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 135, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(4252),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 90, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 772, DateTimeKind.Local).AddTicks(4756),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 78, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 777, DateTimeKind.Local).AddTicks(8999),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 86, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 767, DateTimeKind.Local).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 67, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 684, DateTimeKind.Local).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 910, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 730, DateTimeKind.Local).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 995, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 791, DateTimeKind.Local).AddTicks(4194),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 111, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 663, DateTimeKind.Local).AddTicks(5476),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 884, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 665, DateTimeKind.Local).AddTicks(9191),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 887, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 701, DateTimeKind.Local).AddTicks(5121),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 931, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 92, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 718, DateTimeKind.Local).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 968, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 660, DateTimeKind.Local).AddTicks(4621),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 878, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 673, DateTimeKind.Local).AddTicks(4329),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 895, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 681, DateTimeKind.Local).AddTicks(3297),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 906, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 784, DateTimeKind.Local).AddTicks(4571),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 98, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 690, DateTimeKind.Local).AddTicks(1580),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 917, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 698, DateTimeKind.Local).AddTicks(8333),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 928, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 809, DateTimeKind.Local).AddTicks(5452),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 145, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 795, DateTimeKind.Local).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 118, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 814, DateTimeKind.Local).AddTicks(4350),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 153, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.AlterColumn<float>(
                name: "EMPLOYER_CHARGE",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 713, DateTimeKind.Local).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 959, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 726, DateTimeKind.Local).AddTicks(8269),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 987, DateTimeKind.Local).AddTicks(3066));
        }
    }
}
