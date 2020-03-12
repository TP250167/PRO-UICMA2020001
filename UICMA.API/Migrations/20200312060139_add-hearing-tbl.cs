using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addhearingtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 951, DateTimeKind.Local).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 280, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 968, DateTimeKind.Local).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 296, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 843, DateTimeKind.Local).AddTicks(778),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 161, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 842, DateTimeKind.Local).AddTicks(2206),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 160, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 908, DateTimeKind.Local).AddTicks(8822),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 225, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 28, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 359, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 20, DateTimeKind.Local).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 352, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 25, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 356, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 14, DateTimeKind.Local).AddTicks(5039),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 346, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 897, DateTimeKind.Local).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 214, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 963, DateTimeKind.Local).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 293, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 862, DateTimeKind.Local).AddTicks(6099),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 185, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 867, DateTimeKind.Local).AddTicks(5152),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 188, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 920, DateTimeKind.Local).AddTicks(3700),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 239, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 29, DateTimeKind.Local).AddTicks(884),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 360, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 946, DateTimeKind.Local).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 271, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 857, DateTimeKind.Local).AddTicks(3826),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 182, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 878, DateTimeKind.Local).AddTicks(1699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 196, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 891, DateTimeKind.Local).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 209, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 34, DateTimeKind.Local).AddTicks(2889),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 366, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 903, DateTimeKind.Local).AddTicks(8227),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 220, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 916, DateTimeKind.Local).AddTicks(1808),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 234, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 939, DateTimeKind.Local).AddTicks(6980),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 262, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 958, DateTimeKind.Local).AddTicks(1240),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 288, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.CreateTable(
                name: "NOTICE_OF_HEARING_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    CASE_NUMBER = table.Column<string>(nullable: true),
                    MAIL_DATE = table.Column<DateTime>(nullable: true),
                    HEARING_TIME = table.Column<string>(nullable: true),
                    HEARING_PLACE = table.Column<string>(nullable: true),
                    APPELLANT_TYPE = table.Column<bool>(nullable: false, defaultValue: false),
                    APPELLANT_NAME = table.Column<string>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    ADMINISTRATIVE_LAW_JUDGE = table.Column<string>(nullable: true),
                    EDD_OFFICE = table.Column<string>(nullable: true),
                    HEARING_DATE = table.Column<DateTime>(nullable: true),
                    ISSUES_LIST = table.Column<long>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 43, DateTimeKind.Local).AddTicks(9733)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NOTICE_OF_HEARING_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NOTICE_OF_HEARING_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NOTICE_OF_HEARING_TBL_CLAIM_ID",
                table: "NOTICE_OF_HEARING_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NOTICE_OF_HEARING_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 280, DateTimeKind.Local).AddTicks(7337),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 951, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 296, DateTimeKind.Local).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 968, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 161, DateTimeKind.Local).AddTicks(2534),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 843, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 160, DateTimeKind.Local).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 842, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 225, DateTimeKind.Local).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 908, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 359, DateTimeKind.Local).AddTicks(4934),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 28, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 352, DateTimeKind.Local).AddTicks(2257),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 20, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 356, DateTimeKind.Local).AddTicks(4828),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 25, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 346, DateTimeKind.Local).AddTicks(9585),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 14, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 214, DateTimeKind.Local).AddTicks(6745),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 897, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 293, DateTimeKind.Local).AddTicks(6415),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 963, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 185, DateTimeKind.Local).AddTicks(7516),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 862, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 188, DateTimeKind.Local).AddTicks(9776),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 867, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 239, DateTimeKind.Local).AddTicks(4706),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 920, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 360, DateTimeKind.Local).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 29, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 271, DateTimeKind.Local).AddTicks(9809),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 946, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 182, DateTimeKind.Local).AddTicks(3754),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 857, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 196, DateTimeKind.Local).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 878, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 209, DateTimeKind.Local).AddTicks(507),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 891, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 366, DateTimeKind.Local).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 34, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 220, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 903, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 234, DateTimeKind.Local).AddTicks(2292),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 916, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 262, DateTimeKind.Local).AddTicks(6845),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 939, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 288, DateTimeKind.Local).AddTicks(2741),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 958, DateTimeKind.Local).AddTicks(1240));
        }
    }
}
