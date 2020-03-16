using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class alterexceptiontbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_DOCUMENT_TBL_DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_FORM_TBL_FORM_ID",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_FORM_ID",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 448, DateTimeKind.Local).AddTicks(6436),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 196, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 490, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 227, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 500, DateTimeKind.Local).AddTicks(2768),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 233, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 353, DateTimeKind.Local).AddTicks(4152),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 122, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 367, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 134, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 261, DateTimeKind.Local).AddTicks(7108),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 41, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 260, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 40, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 316, DateTimeKind.Local).AddTicks(5409),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 91, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 455, DateTimeKind.Local).AddTicks(1068),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 201, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 506, DateTimeKind.Local).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 238, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 425, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 176, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 416, DateTimeKind.Local).AddTicks(863),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 169, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 421, DateTimeKind.Local).AddTicks(2091),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 174, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 410, DateTimeKind.Local).AddTicks(8708),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 165, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 305, DateTimeKind.Local).AddTicks(4114),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 82, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 363, DateTimeKind.Local).AddTicks(2199),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 131, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 438, DateTimeKind.Local).AddTicks(2100),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 187, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 279, DateTimeKind.Local).AddTicks(7671),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 58, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 282, DateTimeKind.Local).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 61, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 325, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 99, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 426, DateTimeKind.Local).AddTicks(2523),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 177, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 479, DateTimeKind.Local).AddTicks(2572),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 220, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 520, DateTimeKind.Local).AddTicks(897),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 245, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 348, DateTimeKind.Local).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 117, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 275, DateTimeKind.Local).AddTicks(9528),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 54, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 291, DateTimeKind.Local).AddTicks(4861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 68, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 301, DateTimeKind.Local).AddTicks(3892),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 77, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 430, DateTimeKind.Local).AddTicks(5551),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 180, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.AlterColumn<long>(
                name: "FORM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "CLAIM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "MDDocumentId",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MDFormId",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 310, DateTimeKind.Local).AddTicks(7703),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 87, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 322, DateTimeKind.Local).AddTicks(1475),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 97, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 461, DateTimeKind.Local).AddTicks(9578),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 206, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 444, DateTimeKind.Local).AddTicks(826),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 192, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 468, DateTimeKind.Local).AddTicks(5436),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 211, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 342, DateTimeKind.Local).AddTicks(7356),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 113, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 358, DateTimeKind.Local).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 127, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_MDDocumentId",
                table: "CLAIM_EXCEPTION_TBL",
                column: "MDDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_MDFormId",
                table: "CLAIM_EXCEPTION_TBL",
                column: "MDFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_DOCUMENT_TBL_MDDocumentId",
                table: "CLAIM_EXCEPTION_TBL",
                column: "MDDocumentId",
                principalTable: "MD_DOCUMENT_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_FORM_TBL_MDFormId",
                table: "CLAIM_EXCEPTION_TBL",
                column: "MDFormId",
                principalTable: "MD_FORM_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_DOCUMENT_TBL_MDDocumentId",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_FORM_TBL_MDFormId",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_MDDocumentId",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_MDFormId",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropColumn(
                name: "MDDocumentId",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.DropColumn(
                name: "MDFormId",
                table: "CLAIM_EXCEPTION_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WRIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 196, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 448, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 227, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 490, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 233, DateTimeKind.Local).AddTicks(2281),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 500, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 122, DateTimeKind.Local).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 353, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 134, DateTimeKind.Local).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 367, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 41, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 261, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 40, DateTimeKind.Local).AddTicks(4277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 260, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 91, DateTimeKind.Local).AddTicks(3758),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 316, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_TO_REOPEN_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 201, DateTimeKind.Local).AddTicks(7268),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 455, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "REQUEST_FOR_EMPLOYEE_DATA_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 238, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 506, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 176, DateTimeKind.Local).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 425, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 169, DateTimeKind.Local).AddTicks(6344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 416, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 174, DateTimeKind.Local).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 421, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 165, DateTimeKind.Local).AddTicks(221),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 410, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 82, DateTimeKind.Local).AddTicks(81),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 305, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 131, DateTimeKind.Local).AddTicks(5655),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 363, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 187, DateTimeKind.Local).AddTicks(7976),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 438, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 58, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 279, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 61, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 282, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 99, DateTimeKind.Local).AddTicks(9828),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 325, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 177, DateTimeKind.Local).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 426, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "DETERMINATION_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 220, DateTimeKind.Local).AddTicks(3438),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 479, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_BOARD_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 245, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 520, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 117, DateTimeKind.Local).AddTicks(9794),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 348, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 54, DateTimeKind.Local).AddTicks(8872),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 275, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 68, DateTimeKind.Local).AddTicks(7550),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 291, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 77, DateTimeKind.Local).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 301, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 180, DateTimeKind.Local).AddTicks(8662),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 430, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.AlterColumn<long>(
                name: "FORM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CLAIM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 87, DateTimeKind.Local).AddTicks(2564),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 310, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 97, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 322, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_CHARGE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 206, DateTimeKind.Local).AddTicks(4802),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 461, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BENEFIT_AUDIT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 192, DateTimeKind.Local).AddTicks(5536),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 444, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "BEN_CHAR_CLAIMANT_DETAIL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 211, DateTimeKind.Local).AddTicks(2807),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 468, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 113, DateTimeKind.Local).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 342, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 16, 14, 2, 20, 127, DateTimeKind.Local).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 16, 16, 33, 39, 358, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL",
                column: "DOCUMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_EXCEPTION_TBL_FORM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                column: "FORM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_DOCUMENT_TBL_DOCUMENT_ID",
                table: "CLAIM_EXCEPTION_TBL",
                column: "DOCUMENT_ID",
                principalTable: "MD_DOCUMENT_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLAIM_EXCEPTION_TBL_MD_FORM_TBL_FORM_ID",
                table: "CLAIM_EXCEPTION_TBL",
                column: "FORM_ID",
                principalTable: "MD_FORM_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
