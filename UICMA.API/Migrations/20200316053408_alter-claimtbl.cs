using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class alterclaimtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 269, DateTimeKind.Local).AddTicks(856),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 951, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 300, DateTimeKind.Local).AddTicks(5274),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 981, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 305, DateTimeKind.Local).AddTicks(7292),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 986, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 196, DateTimeKind.Local).AddTicks(9965),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 881, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 208, DateTimeKind.Local).AddTicks(2102),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 893, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 116, DateTimeKind.Local).AddTicks(2553),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 802, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 115, DateTimeKind.Local).AddTicks(3604),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 801, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 166, DateTimeKind.Local).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 851, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 274, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 956, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 310, DateTimeKind.Local).AddTicks(4872),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 990, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(1926),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 932, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 242, DateTimeKind.Local).AddTicks(2228),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 926, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 245, DateTimeKind.Local).AddTicks(6942),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 930, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 237, DateTimeKind.Local).AddTicks(7010),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 922, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 154, DateTimeKind.Local).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 839, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 205, DateTimeKind.Local).AddTicks(1360),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 890, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 259, DateTimeKind.Local).AddTicks(2899),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 943, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 132, DateTimeKind.Local).AddTicks(7070),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 818, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 135, DateTimeKind.Local).AddTicks(1566),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 820, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 175, DateTimeKind.Local).AddTicks(4169),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 859, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(7862),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 933, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 293, DateTimeKind.Local).AddTicks(7395),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 974, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 318, DateTimeKind.Local).AddTicks(457),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 998, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 192, DateTimeKind.Local).AddTicks(6659),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 877, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 129, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 814, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.AddColumn<string>(
                name: "CITY",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "STATE",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZIPCODE",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 142, DateTimeKind.Local).AddTicks(8681),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 828, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 150, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 836, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 252, DateTimeKind.Local).AddTicks(1684),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 936, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 161, DateTimeKind.Local).AddTicks(6079),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 844, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BENEFIT_YEAR_BEGAN",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 172, DateTimeKind.Local).AddTicks(4199),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 856, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 279, DateTimeKind.Local).AddTicks(2696),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 961, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 264, DateTimeKind.Local).AddTicks(1524),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 947, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 283, DateTimeKind.Local).AddTicks(9662),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 966, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 188, DateTimeKind.Local).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 872, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 201, DateTimeKind.Local).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 886, DateTimeKind.Local).AddTicks(2396));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "CITY",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "STATE",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "ZIPCODE",
                table: "CLAIM_TBL");

           

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 951, DateTimeKind.Local).AddTicks(4820),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 269, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 981, DateTimeKind.Local).AddTicks(1308),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 300, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 986, DateTimeKind.Local).AddTicks(2125),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 305, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 881, DateTimeKind.Local).AddTicks(7838),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 196, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 893, DateTimeKind.Local).AddTicks(1617),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 208, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 802, DateTimeKind.Local).AddTicks(6014),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 116, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 801, DateTimeKind.Local).AddTicks(7521),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 115, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 851, DateTimeKind.Local).AddTicks(1906),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 166, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 956, DateTimeKind.Local).AddTicks(6422),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 274, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 990, DateTimeKind.Local).AddTicks(7653),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 310, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 932, DateTimeKind.Local).AddTicks(6152),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 926, DateTimeKind.Local).AddTicks(5445),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 242, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 930, DateTimeKind.Local).AddTicks(1271),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 245, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 922, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 237, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 839, DateTimeKind.Local).AddTicks(7127),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 154, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 890, DateTimeKind.Local).AddTicks(2117),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 205, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 943, DateTimeKind.Local).AddTicks(3813),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 259, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 818, DateTimeKind.Local).AddTicks(303),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 132, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 820, DateTimeKind.Local).AddTicks(5038),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 135, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 859, DateTimeKind.Local).AddTicks(6808),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 175, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 933, DateTimeKind.Local).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 248, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 974, DateTimeKind.Local).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 293, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 998, DateTimeKind.Local).AddTicks(1714),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 318, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 877, DateTimeKind.Local).AddTicks(1808),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 192, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 814, DateTimeKind.Local).AddTicks(7160),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 129, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 828, DateTimeKind.Local).AddTicks(169),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 142, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 836, DateTimeKind.Local).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 150, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 936, DateTimeKind.Local).AddTicks(5263),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 252, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 844, DateTimeKind.Local).AddTicks(7099),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 161, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.AlterColumn<string>(
                name: "BENEFIT_YEAR_BEGAN",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 856, DateTimeKind.Local).AddTicks(8846),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 172, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 961, DateTimeKind.Local).AddTicks(3305),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 279, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 947, DateTimeKind.Local).AddTicks(8582),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 264, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 966, DateTimeKind.Local).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 283, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 872, DateTimeKind.Local).AddTicks(6709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 188, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 13, 17, 26, 45, 886, DateTimeKind.Local).AddTicks(2396),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 11, 4, 8, 201, DateTimeKind.Local).AddTicks(2679));

        }
    }
}
