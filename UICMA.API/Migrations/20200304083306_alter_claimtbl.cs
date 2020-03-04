using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class alter_claimtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "ADDITIONAL_CLAIM",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BENEFIT_YEAR_BEGINNING",
                table: "CLAIM_TBL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_MAILED_TO_EDD",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EFFECTIVE_DATE_OF_CLAIM",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LAST_DATE_WORKED",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MAIL_DATE",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NEW_CLAIM",
                table: "CLAIM_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REASON_FOR_SEPARATION",
                table: "CLAIM_TBL",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADDITIONAL_CLAIM",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "BENEFIT_YEAR_BEGINNING",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "DATE_MAILED_TO_EDD",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "EFFECTIVE_DATE_OF_CLAIM",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "LAST_DATE_WORKED",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "MAIL_DATE",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "NEW_CLAIM",
                table: "CLAIM_TBL");

            migrationBuilder.DropColumn(
                name: "REASON_FOR_SEPARATION",
                table: "CLAIM_TBL");

           
        }
    }
}
