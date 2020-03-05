using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class removequestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LAUSDResponse1",
                table: "CLAIM_INTERVIEW_TBL");

            migrationBuilder.DropColumn(
                name: "LAUSDResponse2",
                table: "CLAIM_INTERVIEW_TBL");

            migrationBuilder.DropColumn(
                name: "LAUSDResponse3",
                table: "CLAIM_INTERVIEW_TBL");

            migrationBuilder.DropColumn(
                name: "Question1",
                table: "CLAIM_INTERVIEW_TBL");

            migrationBuilder.DropColumn(
                name: "Question2",
                table: "CLAIM_INTERVIEW_TBL");

            migrationBuilder.DropColumn(
                name: "Question3",
                table: "CLAIM_INTERVIEW_TBL");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "LAUSDResponse1",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LAUSDResponse2",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LAUSDResponse3",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question1",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question2",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question3",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true);
        }
    }
}
