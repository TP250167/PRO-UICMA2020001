using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class add_default_value : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AlterColumn<bool>(
                name: "IS_MANDATORY",
                table: "MD_DOCUMENT_TBL",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AlterColumn<bool>(
                name: "IS_MANDATORY",
                table: "MD_DOCUMENT_TBL",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

          
        }
    }
}
