using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class ADDDETERMINATIONTABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 559, DateTimeKind.Local).AddTicks(7491),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 126, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 438, DateTimeKind.Local).AddTicks(4877),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 977, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 451, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 1, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 337, DateTimeKind.Local).AddTicks(7801),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 860, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 336, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 859, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 399, DateTimeKind.Local).AddTicks(9774),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 922, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 568, DateTimeKind.Local).AddTicks(5127),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 135, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 530, DateTimeKind.Local).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 90, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 519, DateTimeKind.Local).AddTicks(9290),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 78, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 526, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 86, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 512, DateTimeKind.Local).AddTicks(4324),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 67, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 388, DateTimeKind.Local).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 910, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 447, DateTimeKind.Local).AddTicks(8654),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 995, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 544, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 111, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 355, DateTimeKind.Local).AddTicks(7778),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 884, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 358, DateTimeKind.Local).AddTicks(6719),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 887, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 411, DateTimeKind.Local).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 931, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 531, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 92, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 433, DateTimeKind.Local).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 968, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 352, DateTimeKind.Local).AddTicks(1953),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 878, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 369, DateTimeKind.Local).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 895, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 383, DateTimeKind.Local).AddTicks(2254),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 906, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 535, DateTimeKind.Local).AddTicks(4772),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 98, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 395, DateTimeKind.Local).AddTicks(2875),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 917, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 408, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 928, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 577, DateTimeKind.Local).AddTicks(1431),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 145, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 553, DateTimeKind.Local).AddTicks(2267),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 118, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 585, DateTimeKind.Local).AddTicks(8404),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 153, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 428, DateTimeKind.Local).AddTicks(1294),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 959, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 443, DateTimeKind.Local).AddTicks(4095),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 987, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.CreateTable(
                name: "DETERMINATION_APPEAL_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    TRANSLATOR_LANGUAGE = table.Column<string>(nullable: true),
                    NEED_TRANSLATOR = table.Column<bool>(nullable: false, defaultValue: false),
                    EDD_OFFICE_ADDRESS = table.Column<string>(nullable: true),
                    APPELLANT_ADDRESS = table.Column<string>(nullable: true),
                    APPELLANT_EMAIL = table.Column<string>(nullable: true),
                    APPELLANT_FAX_NUMBER = table.Column<string>(nullable: true),
                    APPELLANT_TELEPHONE_NUMBER = table.Column<string>(nullable: true),
                    APPELLANT_CELL_NUMBER = table.Column<string>(nullable: true),
                    AUTHORIZE_TO_SEND_EMAIL = table.Column<bool>(nullable: false, defaultValue: false),
                    AUTHORIZE_TO_SEND_TEXT = table.Column<bool>(nullable: false, defaultValue: false),
                    EMPLOYER_ACCOUNT_NUMBER = table.Column<string>(nullable: true),
                    AGENT_NAME = table.Column<string>(nullable: true),
                    AGENT_ADDRESS = table.Column<string>(nullable: true),
                    AGENT_CITY = table.Column<string>(nullable: true),
                    APPELLANT_CITY = table.Column<string>(nullable: true),
                    AGENT_STATE = table.Column<string>(nullable: true),
                    AGENT_ZIPCODE = table.Column<string>(nullable: true),
                    APPELLANT_STATE = table.Column<string>(nullable: true),
                    APPELLANT_ZIPCODE = table.Column<string>(nullable: true),
                    FORM_DATE = table.Column<DateTime>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    SIGNATURE = table.Column<string>(nullable: true),
                    APPELLANT_STATEM_NOTICE_DATE = table.Column<string>(nullable: true),
                    APPELLANT_STATEMENT_COMMENTS = table.Column<string>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 596, DateTimeKind.Local).AddTicks(6683)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DETERMINATION_APPEAL_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DETERMINATION_APPEAL_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DETERMINATION_APPEAL_TBL_CLAIM_ID",
                table: "DETERMINATION_APPEAL_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DETERMINATION_APPEAL_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 126, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 559, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 977, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 438, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 1, DateTimeKind.Local).AddTicks(3971),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 451, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 860, DateTimeKind.Local).AddTicks(4822),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 337, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 859, DateTimeKind.Local).AddTicks(138),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 336, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 922, DateTimeKind.Local).AddTicks(118),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 399, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 135, DateTimeKind.Local).AddTicks(4144),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 568, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 90, DateTimeKind.Local).AddTicks(9836),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 530, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 78, DateTimeKind.Local).AddTicks(4717),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 519, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 86, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 526, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 67, DateTimeKind.Local).AddTicks(4134),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 512, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 910, DateTimeKind.Local).AddTicks(8331),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 388, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 995, DateTimeKind.Local).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 447, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 111, DateTimeKind.Local).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 544, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 884, DateTimeKind.Local).AddTicks(873),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 355, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 887, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 358, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 931, DateTimeKind.Local).AddTicks(7955),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 411, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 92, DateTimeKind.Local).AddTicks(1413),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 531, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 968, DateTimeKind.Local).AddTicks(1647),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 433, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 878, DateTimeKind.Local).AddTicks(8843),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 352, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 895, DateTimeKind.Local).AddTicks(9386),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 369, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 906, DateTimeKind.Local).AddTicks(1915),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 383, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 98, DateTimeKind.Local).AddTicks(2141),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 535, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 917, DateTimeKind.Local).AddTicks(4578),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 395, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 928, DateTimeKind.Local).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 408, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 145, DateTimeKind.Local).AddTicks(782),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 577, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 118, DateTimeKind.Local).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 553, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 39, 153, DateTimeKind.Local).AddTicks(3625),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 585, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 959, DateTimeKind.Local).AddTicks(4474),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 428, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 14, 51, 38, 987, DateTimeKind.Local).AddTicks(3066),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 15, 37, 5, 443, DateTimeKind.Local).AddTicks(4095));
        }
    }
}
