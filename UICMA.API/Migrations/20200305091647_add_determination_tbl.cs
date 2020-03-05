using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class add_determination_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "CLAIM_DETERMINATION_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DECISION = table.Column<string>(nullable: true),
                    MAILED_DATE = table.Column<DateTime>(nullable: true),
                    BENEFIT_YEAR_BEGAN = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    FIELD_OFFICE = table.Column<string>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 5, 14, 46, 47, 441, DateTimeKind.Local).AddTicks(7804)),
                    FORM_PATH = table.Column<string>(nullable: true),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLAIM_DETERMINATION_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLAIM_DETERMINATION_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_DETERMINATION_TBL_CLAIM_ID",
                table: "CLAIM_DETERMINATION_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLAIM_DETERMINATION_TBL");
         
        }
    }
}
