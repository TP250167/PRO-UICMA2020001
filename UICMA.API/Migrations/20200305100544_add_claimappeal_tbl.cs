using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class add_claimappeal_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "CLAIM_APPEAL_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FORM_CODE = table.Column<string>(nullable: true),
                    STATE = table.Column<string>(nullable: true),
                    CITY = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(nullable: true),
                    ZIPCODE = table.Column<string>(nullable: true),
                    LAUSD_FAX_DATE = table.Column<DateTime>(nullable: true),
                    BYB_CLAIM_DATE = table.Column<DateTime>(nullable: true),
                    FORM_DATE = table.Column<DateTime>(nullable: true),
                    LAUSD_ACCOUNT_NUMBER = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    LAUSD_ELIGIBILITY_INFORMATION = table.Column<string>(nullable: true),
                    REPRESENTATIVE_NAME = table.Column<string>(nullable: true),
                    PHONE_NUMBER = table.Column<string>(nullable: true),
                    SIGNATURE = table.Column<string>(nullable: true),
                    TITLE = table.Column<string>(nullable: true),
                    DATE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 5, 15, 35, 44, 95, DateTimeKind.Local).AddTicks(7140)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLAIM_APPEAL_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLAIM_APPEAL_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_APPEAL_TBL_CLAIM_ID",
                table: "CLAIM_APPEAL_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLAIM_APPEAL_TBL");

           
        }
    }
}
