using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addbenefitchargetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 799, DateTimeKind.Local).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 20, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 722, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 916, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 733, DateTimeKind.Local).AddTicks(3036),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 931, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 649, DateTimeKind.Local).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 790, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 648, DateTimeKind.Local).AddTicks(1476),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 788, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 693, DateTimeKind.Local).AddTicks(8203),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 868, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 804, DateTimeKind.Local).AddTicks(8219),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 26, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(4252),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 995, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 772, DateTimeKind.Local).AddTicks(4756),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 989, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 777, DateTimeKind.Local).AddTicks(8999),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 992, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 767, DateTimeKind.Local).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 984, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 684, DateTimeKind.Local).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 858, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 730, DateTimeKind.Local).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 927, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 791, DateTimeKind.Local).AddTicks(4194),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 8, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 663, DateTimeKind.Local).AddTicks(5476),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 815, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 665, DateTimeKind.Local).AddTicks(9191),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 820, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 701, DateTimeKind.Local).AddTicks(5121),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 880, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 996, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 718, DateTimeKind.Local).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 910, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 660, DateTimeKind.Local).AddTicks(4621),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 809, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 673, DateTimeKind.Local).AddTicks(4329),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 837, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 681, DateTimeKind.Local).AddTicks(3297),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 852, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 784, DateTimeKind.Local).AddTicks(4571),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 0, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 690, DateTimeKind.Local).AddTicks(1580),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 863, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 698, DateTimeKind.Local).AddTicks(8333),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 874, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 795, DateTimeKind.Local).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 15, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 713, DateTimeKind.Local).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 902, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 726, DateTimeKind.Local).AddTicks(8269),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 920, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.CreateTable(
                name: "BENEFIT_CHARGE_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MAX_AMOUNT_RECEIVED = table.Column<string>(nullable: true),
                    ACTUAL_AMOUNT_PAID = table.Column<string>(nullable: true),
                    AMOUNT_PAID_BY_BYB = table.Column<string>(nullable: true),
                    ISSUED_DATE = table.Column<DateTime>(nullable: true),
                    AMOUNT_PAID_BY_FISCAL_YEAR = table.Column<string>(nullable: true),
                    ACCOUNT_ID = table.Column<string>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    LETTER_ID = table.Column<long>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 809, DateTimeKind.Local).AddTicks(5452)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BENEFIT_CHARGE_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BENEFIT_CHARGE_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    CLAIMANT_SSN = table.Column<string>(nullable: true),
                    CLAIM_DATE = table.Column<DateTime>(nullable: true),
                    CLAIM_TYPE = table.Column<string>(nullable: true),
                    PCM_CODE = table.Column<string>(nullable: true),
                    CHARGE_CODE = table.Column<string>(nullable: true),
                    EMPLOYER_CHARGE = table.Column<float>(nullable: true),
                    CHARGE_QUARTER_DATE = table.Column<DateTime>(nullable: true),
                    FORM_ID = table.Column<long>(nullable: false),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 814, DateTimeKind.Local).AddTicks(4350)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BEN_CHAR_CLAIMANT_DETAIL_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BEN_CHAR_CLAIMANT_DETAIL_TBL_BENEFIT_CHARGE_TBL_FORM_ID",
                        column: x => x.FORM_ID,
                        principalTable: "BENEFIT_CHARGE_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BEN_CHAR_CLAIMANT_DETAIL_TBL_FORM_ID",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                column: "FORM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BENEFIT_CHARGE_TBL_CLAIM_ID",
                table: "BENEFIT_CHARGE_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BEN_CHAR_CLAIMANT_DETAIL_TBL");

            migrationBuilder.DropTable(
                name: "BENEFIT_CHARGE_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 20, DateTimeKind.Local).AddTicks(7847),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 799, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 916, DateTimeKind.Local).AddTicks(2893),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 722, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 931, DateTimeKind.Local).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 733, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 790, DateTimeKind.Local).AddTicks(5015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 649, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 788, DateTimeKind.Local).AddTicks(8959),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 648, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 868, DateTimeKind.Local).AddTicks(7898),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 693, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 26, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 804, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 995, DateTimeKind.Local).AddTicks(8868),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 989, DateTimeKind.Local).AddTicks(332),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 772, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 992, DateTimeKind.Local).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 777, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 984, DateTimeKind.Local).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 767, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 858, DateTimeKind.Local).AddTicks(2230),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 684, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 927, DateTimeKind.Local).AddTicks(4502),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 730, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 8, DateTimeKind.Local).AddTicks(1636),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 791, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 815, DateTimeKind.Local).AddTicks(9259),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 663, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 820, DateTimeKind.Local).AddTicks(7661),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 665, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 880, DateTimeKind.Local).AddTicks(2569),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 701, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 996, DateTimeKind.Local).AddTicks(4865),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 780, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 910, DateTimeKind.Local).AddTicks(304),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 718, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 809, DateTimeKind.Local).AddTicks(6125),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 660, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 837, DateTimeKind.Local).AddTicks(5881),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 673, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 852, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 681, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 0, DateTimeKind.Local).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 784, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 863, DateTimeKind.Local).AddTicks(4699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 690, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 874, DateTimeKind.Local).AddTicks(4886),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 698, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 27, 15, DateTimeKind.Local).AddTicks(3501),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 795, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 902, DateTimeKind.Local).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 713, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 12, 23, 26, 920, DateTimeKind.Local).AddTicks(9158),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 45, 26, 726, DateTimeKind.Local).AddTicks(8269));
        }
    }
}
