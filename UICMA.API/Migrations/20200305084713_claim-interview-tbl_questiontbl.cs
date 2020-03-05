using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class claiminterviewtbl_questiontbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "CLAIM_INTERVIEW_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CITY = table.Column<string>(nullable: true),
                    STATE = table.Column<string>(nullable: true),
                    ZIPCODE = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(nullable: true),
                    LAUSD_FAX_DATE = table.Column<DateTime>(nullable: true),
                    BYB_CLAIM_DATE = table.Column<DateTime>(nullable: true),
                    EFFECTIVE_DATE = table.Column<DateTime>(nullable: true),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    STATUS = table.Column<string>(nullable: true),
                    Question1 = table.Column<string>(nullable: true),
                    LAUSDResponse1 = table.Column<string>(nullable: true),
                    Question2 = table.Column<string>(nullable: true),
                    LAUSDResponse2 = table.Column<string>(nullable: true),
                    Question3 = table.Column<string>(nullable: true),
                    LAUSDResponse3 = table.Column<string>(nullable: true),
                    DATE = table.Column<DateTime>(nullable: true),
                    TIME = table.Column<string>(nullable: true),
                    DET_INTERVIEWER = table.Column<string>(nullable: true),
                    INTERVIEWER_PHONE_NUMBER = table.Column<string>(nullable: true),
                    REPRESENTATIVE_NAME = table.Column<string>(nullable: true),
                    PHONE_NUMBER = table.Column<string>(nullable: true),
                    SIGNATURE = table.Column<string>(nullable: true),
                    TITLE = table.Column<string>(nullable: true),
                    REPRESENTATIVE_DATE = table.Column<DateTime>(nullable: true),
                    ISSUES_LIST = table.Column<long>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 5, 14, 17, 13, 390, DateTimeKind.Local).AddTicks(8564)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLAIM_INTERVIEW_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLAIM_INTERVIEW_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONS_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    CREATED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 5, 14, 17, 13, 394, DateTimeKind.Local).AddTicks(5627)),
                    FORM_ID = table.Column<long>(nullable: false),
                    LAUSD_QUESTIONS = table.Column<string>(nullable: true),
                    LAUSD_RESPONSES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("QUESTIONS_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QUESTIONS_TBL_CLAIM_INTERVIEW_TBL_FORM_ID",
                        column: x => x.FORM_ID,
                        principalTable: "CLAIM_INTERVIEW_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLAIM_INTERVIEW_TBL_CLAIM_ID",
                table: "CLAIM_INTERVIEW_TBL",
                column: "CLAIM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QUESTIONS_TBL_FORM_ID",
                table: "QUESTIONS_TBL",
                column: "FORM_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QUESTIONS_TBL");

            migrationBuilder.DropTable(
                name: "CLAIM_INTERVIEW_TBL");

          
        }
    }
}
