using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class add_aljdecision_cuiab_wages_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADDITIONAL_INFORMATION_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    MAIL_DATE = table.Column<DateTime>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    CONTROL_NUMBER = table.Column<string>(nullable: true),
                    CLAIM_EFFECTIVE_DATE = table.Column<DateTime>(nullable: true),
                    EMPLOYER_NAME = table.Column<string>(nullable: true),
                    PHONE_NUMBER = table.Column<string>(nullable: true),
                    EMPLOYER_ADDRESS = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 6, 18, 42, 58, 204, DateTimeKind.Local).AddTicks(6972)),
                    CREATED_BY = table.Column<string>(nullable: true),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    FORM_CODE = table.Column<string>(nullable: true),
                    FORM_PATH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ADDITIONAL_INFORMATION_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ADDITIONAL_INFORMATION_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ALJ_DECISION_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PARTIES_APPEARING = table.Column<string>(nullable: true),
                    DECISION = table.Column<string>(nullable: true),
                    FORMERLY_CASE_NUMBER = table.Column<string>(nullable: true),
                    CASE_NUMBER = table.Column<string>(nullable: true),
                    MAIL_DATE = table.Column<DateTime>(nullable: true),
                    BYB_CLAIM_DATE = table.Column<DateTime>(nullable: true),
                    APPLICATION_REOPEN_DATE = table.Column<DateTime>(nullable: true),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    EMPLOYER_INFO = table.Column<string>(nullable: true),
                    ALJ_NAME = table.Column<string>(nullable: true),
                    PLACE_OF_HEARING_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 6, 18, 42, 58, 174, DateTimeKind.Local).AddTicks(7547)),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    FORM_CODE = table.Column<string>(nullable: true),
                    FORM_PATH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ALJ_DECISION_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ALJ_DECISION_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CUIAB_ACKNOWLEDGEMENT_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    AB_CASE_NUMBER = table.Column<string>(nullable: true),
                    APPELLANT = table.Column<string>(nullable: true),
                    ALJ_DECISION_NUMBER = table.Column<string>(nullable: true),
                    DATE_MAILED = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    ACCOUNT_NUMBER = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(nullable: true),
                    LAUSD_ADDRESS = table.Column<string>(nullable: true),
                    CUIAB_ADDRESS = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 6, 18, 42, 58, 185, DateTimeKind.Local).AddTicks(8557)),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    FORM_CODE = table.Column<string>(nullable: true),
                    FORM_PATH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CUIAB_ACKNOWLEDGEMENT_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CUIAB_ACKNOWLEDGEMENT_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WAGES_AFTER_APPEAL_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    MAILING_DATE = table.Column<DateTime>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    CASE_NUMBER = table.Column<string>(nullable: true),
                    DEADLINE_DATE = table.Column<DateTime>(nullable: true),
                    PREPARER_NAME = table.Column<string>(nullable: true),
                    TELEPHONE_NUMBER = table.Column<string>(nullable: true),
                    FAX_NUMBER = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 6, 18, 42, 58, 195, DateTimeKind.Local).AddTicks(2343)),
                    CREATED_BY = table.Column<string>(nullable: true),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    FORM_CODE = table.Column<string>(nullable: true),
                    FORM_PATH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("WAGES_AFTER_APPEAL_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WAGES_AFTER_APPEAL_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

          
            migrationBuilder.CreateIndex(
                name: "IX_ADDITIONAL_INFORMATION_TBL_CLAIM_ID",
                table: "ADDITIONAL_INFORMATION_TBL",
                column: "CLAIM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ALJ_DECISION_TBL_CLAIM_ID",
                table: "ALJ_DECISION_TBL",
                column: "CLAIM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CUIAB_ACKNOWLEDGEMENT_TBL_CLAIM_ID",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                column: "CLAIM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WAGES_AFTER_APPEAL_TBL_CLAIM_ID",
                table: "WAGES_AFTER_APPEAL_TBL",
                column: "CLAIM_ID",
                unique: true);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropTable(
                name: "ADDITIONAL_INFORMATION_TBL");

            migrationBuilder.DropTable(
                name: "ALJ_DECISION_TBL");

            migrationBuilder.DropTable(
                name: "CUIAB_ACKNOWLEDGEMENT_TBL");

            migrationBuilder.DropTable(
                name: "WAGES_AFTER_APPEAL_TBL");

           
        }
    }
}
