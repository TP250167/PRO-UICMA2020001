using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addformdocumentmaptbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "FORM_DOCUMENT_MAP_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DOCUMENT_ID = table.Column<long>(nullable: false),
                    FORM_ID = table.Column<long>(nullable: false),
                    CLAIM_ID = table.Column<long>(nullable: false),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 11, 14, 37, 56, 413, DateTimeKind.Local).AddTicks(9137)),
                    CHANNEL = table.Column<string>(nullable: true),
                    RECEIVED_DATE = table.Column<DateTime>(nullable: true),
                    UPLOAD_FILE_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FORM_DOCUMENT_MAP_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FORM_DOCUMENT_MAP_TBL_MD_DOCUMENT_TBL_DOCUMENT_ID",
                        column: x => x.DOCUMENT_ID,
                        principalTable: "MD_DOCUMENT_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORM_DOCUMENT_MAP_TBL_MD_FORM_TBL_FORM_ID",
                        column: x => x.FORM_ID,
                        principalTable: "MD_FORM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_DOCUMENT_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "DOCUMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FORM_DOCUMENT_MAP_TBL_FORM_ID",
                table: "FORM_DOCUMENT_MAP_TBL",
                column: "FORM_ID");

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.DropTable(
                name: "FORM_DOCUMENT_MAP_TBL");

        }
    }
}
