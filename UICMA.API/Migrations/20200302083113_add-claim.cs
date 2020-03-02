using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addclaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLAIM_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    REQUEST_NUMBER = table.Column<string>(nullable: true),
                    TYPE = table.Column<string>(nullable: true),
                    REQUEST_TITLE = table.Column<string>(nullable: true),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    CURRENT_STAGE = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 2, 14, 1, 13, 301, DateTimeKind.Local).AddTicks(4688)),
                    GENDER = table.Column<string>(nullable: true),
                    EMPLOYEE_NUMBER = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLAIM_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MD_DOCUMENT_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DOCUMENT_NAME = table.Column<string>(nullable: true),
                    DOCUMENT_STATUS = table.Column<string>(nullable: true),
                    DOCUMENT_DESCRIPTION = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 2, 14, 1, 13, 306, DateTimeKind.Local).AddTicks(2060)),
                    IS_MANDATORY = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MD_DOCUMENT_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MD_FORM_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FORM_NAME = table.Column<string>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    FORM_STATUS = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 2, 14, 1, 13, 303, DateTimeKind.Local).AddTicks(8158))
                },
                constraints: table =>
                {
                    table.PrimaryKey("MD_FORM_ID", x => x.Id);
                });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropTable(
                name: "CLAIM_TBL");

            migrationBuilder.DropTable(
                name: "MD_DOCUMENT_TBL");

            migrationBuilder.DropTable(
                name: "MD_FORM_TBL");

          
        }
    }
}
