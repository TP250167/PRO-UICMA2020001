using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addsample2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "sample_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    documenttttt = table.Column<long>(nullable: false),
                    formmmm = table.Column<long>(nullable: false),
                    ClaimmY = table.Column<long>(nullable: false),
                    ZIPCODE = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 5, 17, 16, 35, 711, DateTimeKind.Local).AddTicks(9483)),
                    STATE = table.Column<string>(nullable: true),
                    CITY = table.Column<DateTime>(nullable: true),
                    ZIPsfsdfCODE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("testttt_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sample_TBL_MD_DOCUMENT_TBL_documenttttt",
                        column: x => x.documenttttt,
                        principalTable: "MD_DOCUMENT_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sample_TBL_MD_FORM_TBL_formmmm",
                        column: x => x.formmmm,
                        principalTable: "MD_FORM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

          
            migrationBuilder.CreateIndex(
                name: "IX_sample_TBL_documenttttt",
                table: "sample_TBL",
                column: "documenttttt");

            migrationBuilder.CreateIndex(
                name: "IX_sample_TBL_formmmm",
                table: "sample_TBL",
                column: "formmmm");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
                name: "sample_TBL");

          
        }
    }
}
