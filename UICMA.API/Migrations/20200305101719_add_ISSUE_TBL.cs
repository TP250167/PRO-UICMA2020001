using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class add_ISSUE_TBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "ISSUES_LIST_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ISSUE_CODE = table.Column<string>(nullable: true),
                    ISSUE_DECRIPTION = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 5, 15, 47, 19, 335, DateTimeKind.Local).AddTicks(9165))
                },
                constraints: table =>
                {
                    table.PrimaryKey("ISSUES_LIST_ID", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ISSUES_LIST_TBL");

           
        }
    }
}
