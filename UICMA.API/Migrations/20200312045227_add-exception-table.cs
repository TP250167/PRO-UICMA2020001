using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addexceptiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 280, DateTimeKind.Local).AddTicks(7337),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 684, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 296, DateTimeKind.Local).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 696, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 161, DateTimeKind.Local).AddTicks(2534),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 160, DateTimeKind.Local).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 225, DateTimeKind.Local).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 641, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 359, DateTimeKind.Local).AddTicks(4934),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 740, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 352, DateTimeKind.Local).AddTicks(2257),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 734, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 356, DateTimeKind.Local).AddTicks(4828),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 737, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 346, DateTimeKind.Local).AddTicks(9585),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 729, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 214, DateTimeKind.Local).AddTicks(6745),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 629, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 293, DateTimeKind.Local).AddTicks(6415),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 693, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 185, DateTimeKind.Local).AddTicks(7516),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 605, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 188, DateTimeKind.Local).AddTicks(9776),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 607, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 239, DateTimeKind.Local).AddTicks(4706),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 655, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 360, DateTimeKind.Local).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 666, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 271, DateTimeKind.Local).AddTicks(9809),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 680, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 182, DateTimeKind.Local).AddTicks(3754),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 602, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 196, DateTimeKind.Local).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 615, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 209, DateTimeKind.Local).AddTicks(507),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 623, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 220, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 634, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 234, DateTimeKind.Local).AddTicks(2292),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 650, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 262, DateTimeKind.Local).AddTicks(6845),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 675, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 288, DateTimeKind.Local).AddTicks(2741),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 689, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.CreateTable(
                name: "CLAIM_EXCEPTION_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    DOCUMENT_ID = table.Column<long>(nullable: false),
                    FORM_ID = table.Column<long>(nullable: false),
                    EXCEPTION_REASON = table.Column<string>(nullable: true),
                    EXCEPTION_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 366, DateTimeKind.Local).AddTicks(1863))
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLAIM_EXCEPTION_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLAIM_EXCEPTION_TBL_MD_DOCUMENT_TBL_DOCUMENT_ID",
                        column: x => x.DOCUMENT_ID,
                        principalTable: "MD_DOCUMENT_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLAIM_EXCEPTION_TBL_MD_FORM_TBL_FORM_ID",
                        column: x => x.FORM_ID,
                        principalTable: "MD_FORM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL",
                column: "DOCUMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_FORM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                column: "FORM_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 684, DateTimeKind.Local).AddTicks(4703),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 280, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 696, DateTimeKind.Local).AddTicks(1086),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 296, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 161, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 160, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 641, DateTimeKind.Local).AddTicks(1233),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 225, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 740, DateTimeKind.Local).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 359, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 734, DateTimeKind.Local).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 352, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 737, DateTimeKind.Local).AddTicks(7186),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 356, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 729, DateTimeKind.Local).AddTicks(7730),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 346, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 629, DateTimeKind.Local).AddTicks(439),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 214, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 693, DateTimeKind.Local).AddTicks(2861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 293, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 605, DateTimeKind.Local).AddTicks(5265),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 185, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 607, DateTimeKind.Local).AddTicks(8831),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 188, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 655, DateTimeKind.Local).AddTicks(3628),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 239, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 666, DateTimeKind.Local).AddTicks(1085),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 360, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 680, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 271, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 602, DateTimeKind.Local).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 182, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 615, DateTimeKind.Local).AddTicks(3227),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 196, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 623, DateTimeKind.Local).AddTicks(5133),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 209, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 634, DateTimeKind.Local).AddTicks(6972),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 220, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 650, DateTimeKind.Local).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 234, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 675, DateTimeKind.Local).AddTicks(7885),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 262, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 689, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 10, 22, 27, 288, DateTimeKind.Local).AddTicks(2741));
        }
    }
}
