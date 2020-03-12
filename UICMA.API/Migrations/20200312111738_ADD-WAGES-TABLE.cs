using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class ADDWAGESTABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 692, DateTimeKind.Local).AddTicks(987),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 559, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 589, DateTimeKind.Local).AddTicks(1142),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 438, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 609, DateTimeKind.Local).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 451, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 465, DateTimeKind.Local).AddTicks(117),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 337, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 463, DateTimeKind.Local).AddTicks(8249),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 336, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 533, DateTimeKind.Local).AddTicks(9400),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 399, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 700, DateTimeKind.Local).AddTicks(4890),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 568, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 669, DateTimeKind.Local).AddTicks(9096),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 530, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 662, DateTimeKind.Local).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 519, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 667, DateTimeKind.Local).AddTicks(934),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 526, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 658, DateTimeKind.Local).AddTicks(404),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 512, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 516, DateTimeKind.Local).AddTicks(1742),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 388, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 604, DateTimeKind.Local).AddTicks(888),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 447, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 682, DateTimeKind.Local).AddTicks(8204),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 544, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 483, DateTimeKind.Local).AddTicks(7295),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 355, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 486, DateTimeKind.Local).AddTicks(4699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 358, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 548, DateTimeKind.Local).AddTicks(4779),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 411, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 670, DateTimeKind.Local).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 531, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 725, DateTimeKind.Local).AddTicks(5375),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 596, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 580, DateTimeKind.Local).AddTicks(9842),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 433, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 480, DateTimeKind.Local).AddTicks(2648),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 352, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 496, DateTimeKind.Local).AddTicks(3932),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 369, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 509, DateTimeKind.Local).AddTicks(6861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 383, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 674, DateTimeKind.Local).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 535, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 526, DateTimeKind.Local).AddTicks(2595),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 395, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 543, DateTimeKind.Local).AddTicks(5075),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 408, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 706, DateTimeKind.Local).AddTicks(9636),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 577, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 687, DateTimeKind.Local).AddTicks(7188),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 553, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 714, DateTimeKind.Local).AddTicks(2193),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 585, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 572, DateTimeKind.Local).AddTicks(5707),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 428, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 596, DateTimeKind.Local).AddTicks(9902),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 443, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.CreateTable(
                name: "WAGES_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    OTHER_SSN = table.Column<string>(nullable: true),
                    CLAIMDATE = table.Column<DateTime>(nullable: true),
                    FIELD_OFFICE_PHONE_NUMBER = table.Column<string>(nullable: true),
                    FIELD_OFFICE_ADDRESS = table.Column<string>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    POSTMARKED_RESPONSE_DATE = table.Column<DateTime>(nullable: true),
                    WAGES_REPORT = table.Column<string>(nullable: true),
                    WAGES_QUARTER1_DATE = table.Column<string>(nullable: true),
                    WAGES_QUARTER2_DATE = table.Column<string>(nullable: true),
                    WAGES_QUARTER3_DATE = table.Column<string>(nullable: true),
                    WAGES_QUARTER4_DATE = table.Column<string>(nullable: true),
                    WAGES_QUARTER1_AMOUNT = table.Column<string>(nullable: true),
                    WAGES_QUARTER2_AMOUNT = table.Column<string>(nullable: true),
                    WAGES_QUARTER3_AMOUNT = table.Column<string>(nullable: true),
                    WAGES_QUARTER4_AMOUNT = table.Column<string>(nullable: true),
                    TOTAL_WAGES_FOR_EMPLOYEE = table.Column<string>(nullable: true),
                    TOTAL_WAGES_FOR_ALL_EMPLOYEES = table.Column<string>(nullable: true),
                    CLAIMANT_WEEKLY_BENEFIT_AMT = table.Column<string>(nullable: true),
                    BENEFIT_CHARGE_RESERVE_ACC = table.Column<string>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 733, DateTimeKind.Local).AddTicks(4179)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("WAGES_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WAGES_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WAGES_TBL_CLAIM_ID",
                table: "WAGES_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WAGES_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 559, DateTimeKind.Local).AddTicks(7491),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 692, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 438, DateTimeKind.Local).AddTicks(4877),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 589, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 451, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 609, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 337, DateTimeKind.Local).AddTicks(7801),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 465, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 336, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 463, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 399, DateTimeKind.Local).AddTicks(9774),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 533, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 568, DateTimeKind.Local).AddTicks(5127),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 700, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 530, DateTimeKind.Local).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 669, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 519, DateTimeKind.Local).AddTicks(9290),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 662, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 526, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 667, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 512, DateTimeKind.Local).AddTicks(4324),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 658, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 388, DateTimeKind.Local).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 516, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 447, DateTimeKind.Local).AddTicks(8654),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 604, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 544, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 682, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 355, DateTimeKind.Local).AddTicks(7778),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 483, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 358, DateTimeKind.Local).AddTicks(6719),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 486, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 411, DateTimeKind.Local).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 548, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 531, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 670, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 596, DateTimeKind.Local).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 725, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 433, DateTimeKind.Local).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 580, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 352, DateTimeKind.Local).AddTicks(1953),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 480, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 369, DateTimeKind.Local).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 496, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 383, DateTimeKind.Local).AddTicks(2254),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 509, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 535, DateTimeKind.Local).AddTicks(4772),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 674, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 395, DateTimeKind.Local).AddTicks(2875),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 526, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 408, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 543, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 577, DateTimeKind.Local).AddTicks(1431),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 706, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 553, DateTimeKind.Local).AddTicks(2267),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 687, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 585, DateTimeKind.Local).AddTicks(8404),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 714, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 428, DateTimeKind.Local).AddTicks(1294),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 572, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 443, DateTimeKind.Local).AddTicks(4095),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 16, 47, 37, 596, DateTimeKind.Local).AddTicks(9902));
        }
    }
}
