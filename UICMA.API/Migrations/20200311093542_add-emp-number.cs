using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addempnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RetrySucess",
                table: "RA_RECIPIENT_TBL",
                newName: "RETRY_SUCESS");

            migrationBuilder.RenameColumn(
                name: "RetryFail",
                table: "RA_RECIPIENT_TBL",
                newName: "RETRY_FAIL");

          

            migrationBuilder.AddColumn<string>(
                name: "REQUEST_TYPE",
                table: "RA_RECIPIENT_TBL",
                nullable: true);

           

            migrationBuilder.AddColumn<string>(
                name: "EMPLOYEE_NUMBER",
                table: "NOTIFICATION_TBL",
                nullable: true);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "REQUEST_TYPE",
                table: "RA_RECIPIENT_TBL");

            migrationBuilder.DropColumn(
                name: "EMPLOYEE_NUMBER",
                table: "NOTIFICATION_TBL");

            migrationBuilder.RenameColumn(
                name: "RETRY_SUCESS",
                table: "RA_RECIPIENT_TBL",
                newName: "RetrySucess");

            migrationBuilder.RenameColumn(
                name: "RETRY_FAIL",
                table: "RA_RECIPIENT_TBL",
                newName: "RetryFail");

        }
    }
}
