using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addrequesttoreopentbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 20, DateTimeKind.Local).AddTicks(7847),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 408, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 916, DateTimeKind.Local).AddTicks(2893),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 296, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 931, DateTimeKind.Local).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 308, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 790, DateTimeKind.Local).AddTicks(5015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 195, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 788, DateTimeKind.Local).AddTicks(8959),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 194, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 868, DateTimeKind.Local).AddTicks(7898),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 253, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 995, DateTimeKind.Local).AddTicks(8868),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 374, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 989, DateTimeKind.Local).AddTicks(332),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 364, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 992, DateTimeKind.Local).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 984, DateTimeKind.Local).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 357, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 858, DateTimeKind.Local).AddTicks(2230),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 242, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 927, DateTimeKind.Local).AddTicks(4502),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 304, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 8, DateTimeKind.Local).AddTicks(1636),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 395, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 815, DateTimeKind.Local).AddTicks(9259),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 212, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 820, DateTimeKind.Local).AddTicks(7661),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 215, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 880, DateTimeKind.Local).AddTicks(2569),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 265, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 996, DateTimeKind.Local).AddTicks(4865),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 375, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 910, DateTimeKind.Local).AddTicks(304),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 291, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 809, DateTimeKind.Local).AddTicks(6125),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 209, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 837, DateTimeKind.Local).AddTicks(5881),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 224, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 852, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 236, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 0, DateTimeKind.Local).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 380, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 863, DateTimeKind.Local).AddTicks(4699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 247, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 874, DateTimeKind.Local).AddTicks(4886),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 262, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 15, DateTimeKind.Local).AddTicks(3501),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 401, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 902, DateTimeKind.Local).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 284, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 920, DateTimeKind.Local).AddTicks(9158),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 300, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.CreateTable(
                name: "REQUEST_TO_REOPEN_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    ACCOUNT_NUMBER = table.Column<string>(nullable: true),
                    CASE_NUMBER = table.Column<string>(nullable: true),
                    MAIL_DATE = table.Column<DateTime>(nullable: true),
                    HEARING_TIME = table.Column<string>(nullable: true),
                    SIGNATURE = table.Column<string>(nullable: true),
                    EMPLOYER = table.Column<string>(nullable: true),
                    APPEAL_OFFICE_ADDRESS = table.Column<string>(nullable: true),
                    CITY = table.Column<string>(nullable: true),
                    STATE = table.Column<string>(nullable: true),
                    ZIPCODE = table.Column<string>(nullable: true),
                    HEARING_DATE = table.Column<DateTime>(nullable: true),
                    ADMIN_LAW_JUDGE_SERVER = table.Column<long>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 26, DateTimeKind.Local).AddTicks(5885)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REQUEST_TO_REOPEN_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_REQUEST_TO_REOPEN_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_REQUEST_TO_REOPEN_TBL_CLAIM_ID",
                table: "REQUEST_TO_REOPEN_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REQUEST_TO_REOPEN_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 408, DateTimeKind.Local).AddTicks(7296),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 20, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 296, DateTimeKind.Local).AddTicks(2918),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 916, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 308, DateTimeKind.Local).AddTicks(5949),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 931, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 195, DateTimeKind.Local).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 790, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 194, DateTimeKind.Local).AddTicks(1958),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 788, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 253, DateTimeKind.Local).AddTicks(4258),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 868, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 374, DateTimeKind.Local).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 995, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 364, DateTimeKind.Local).AddTicks(8967),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 989, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 369, DateTimeKind.Local).AddTicks(4480),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 992, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 357, DateTimeKind.Local).AddTicks(9057),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 984, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 242, DateTimeKind.Local).AddTicks(2454),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 858, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 304, DateTimeKind.Local).AddTicks(9679),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 927, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 395, DateTimeKind.Local).AddTicks(675),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 8, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 212, DateTimeKind.Local).AddTicks(8053),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 815, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 215, DateTimeKind.Local).AddTicks(4699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 820, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 265, DateTimeKind.Local).AddTicks(9391),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 880, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 375, DateTimeKind.Local).AddTicks(5815),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 996, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 291, DateTimeKind.Local).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 910, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 209, DateTimeKind.Local).AddTicks(2809),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 809, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 224, DateTimeKind.Local).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 837, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 236, DateTimeKind.Local).AddTicks(8128),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 852, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 380, DateTimeKind.Local).AddTicks(6421),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 0, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 247, DateTimeKind.Local).AddTicks(9420),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 863, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 262, DateTimeKind.Local).AddTicks(1),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 874, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 401, DateTimeKind.Local).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 15, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 284, DateTimeKind.Local).AddTicks(2477),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 902, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 48, 13, 300, DateTimeKind.Local).AddTicks(8098),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 920, DateTimeKind.Local).AddTicks(9158));
        }
    }
}
