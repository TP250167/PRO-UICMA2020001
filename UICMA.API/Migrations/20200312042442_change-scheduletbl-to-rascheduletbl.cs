using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class changescheduletbltorascheduletbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RA_ASSOCIATED_DOCUMENT_TBL_SCHEDULE_TBL_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_RA_BATCH_SCHEDULE_MAP_TBL_SCHEDULE_TBL_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL");

            migrationBuilder.RenameColumn(
                name: "SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                newName: "RA_SCHEDULE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_RA_BATCH_SCHEDULE_MAP_TBL_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                newName: "IX_RA_BATCH_SCHEDULE_MAP_TBL_RA_SCHEDULE_ID");

            migrationBuilder.RenameColumn(
                name: "SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                newName: "RA_SCHEDULE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_RA_ASSOCIATED_DOCUMENT_TBL_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                newName: "IX_RA_ASSOCIATED_DOCUMENT_TBL_RA_SCHEDULE_ID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 684, DateTimeKind.Local).AddTicks(4703),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 781, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 696, DateTimeKind.Local).AddTicks(1086),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 792, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 705, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 704, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 641, DateTimeKind.Local).AddTicks(1233),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 751, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 740, DateTimeKind.Local).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 844, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 734, DateTimeKind.Local).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 835, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 737, DateTimeKind.Local).AddTicks(7186),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 839, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 729, DateTimeKind.Local).AddTicks(7730),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 827, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 629, DateTimeKind.Local).AddTicks(439),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 742, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 693, DateTimeKind.Local).AddTicks(2861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 789, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 605, DateTimeKind.Local).AddTicks(5265),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 720, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 607, DateTimeKind.Local).AddTicks(8831),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 722, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 655, DateTimeKind.Local).AddTicks(3628),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 759, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 666, DateTimeKind.Local).AddTicks(1085),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 765, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 680, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 777, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 602, DateTimeKind.Local).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 717, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 615, DateTimeKind.Local).AddTicks(3227),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 730, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 623, DateTimeKind.Local).AddTicks(5133),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 738, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 634, DateTimeKind.Local).AddTicks(6972),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 747, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 650, DateTimeKind.Local).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 756, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 675, DateTimeKind.Local).AddTicks(7885),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 772, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 689, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 785, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.AddForeignKey(
                name: "ASS_DOC_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                column: "RA_SCHEDULE_ID",
                principalTable: "RA_SCHEDULE_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RA_BATCH_SCHEDULE_MAP_TBL_RA_SCHEDULE_TBL_RA_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                column: "RA_SCHEDULE_ID",
                principalTable: "RA_SCHEDULE_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ASS_DOC_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_RA_BATCH_SCHEDULE_MAP_TBL_RA_SCHEDULE_TBL_RA_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL");

            migrationBuilder.RenameColumn(
                name: "RA_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                newName: "SCHEDULE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_RA_BATCH_SCHEDULE_MAP_TBL_RA_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                newName: "IX_RA_BATCH_SCHEDULE_MAP_TBL_SCHEDULE_ID");

            migrationBuilder.RenameColumn(
                name: "RA_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                newName: "SCHEDULE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_RA_ASSOCIATED_DOCUMENT_TBL_RA_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                newName: "IX_RA_ASSOCIATED_DOCUMENT_TBL_SCHEDULE_ID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 781, DateTimeKind.Local).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 684, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 792, DateTimeKind.Local).AddTicks(7247),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 696, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 705, DateTimeKind.Local).AddTicks(6664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 704, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 590, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 751, DateTimeKind.Local).AddTicks(2375),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 641, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 844, DateTimeKind.Local).AddTicks(7815),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 740, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 835, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 734, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 839, DateTimeKind.Local).AddTicks(7191),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 737, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 827, DateTimeKind.Local).AddTicks(7928),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 729, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 742, DateTimeKind.Local).AddTicks(3868),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 629, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 789, DateTimeKind.Local).AddTicks(7910),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 693, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 720, DateTimeKind.Local).AddTicks(2186),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 605, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 722, DateTimeKind.Local).AddTicks(5967),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 607, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 759, DateTimeKind.Local).AddTicks(4191),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 655, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 765, DateTimeKind.Local).AddTicks(5905),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 666, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 777, DateTimeKind.Local).AddTicks(970),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 680, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 717, DateTimeKind.Local).AddTicks(1885),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 602, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 730, DateTimeKind.Local).AddTicks(9418),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 615, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 738, DateTimeKind.Local).AddTicks(7832),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 623, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 747, DateTimeKind.Local).AddTicks(4428),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 634, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 756, DateTimeKind.Local).AddTicks(7293),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 650, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 772, DateTimeKind.Local).AddTicks(188),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 675, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 15, 5, 41, 785, DateTimeKind.Local).AddTicks(9752),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 9, 54, 42, 689, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.AddForeignKey(
                name: "FK_RA_ASSOCIATED_DOCUMENT_TBL_SCHEDULE_TBL_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                column: "SCHEDULE_ID",
                principalTable: "SCHEDULE_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RA_BATCH_SCHEDULE_MAP_TBL_SCHEDULE_TBL_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                column: "SCHEDULE_ID",
                principalTable: "SCHEDULE_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
