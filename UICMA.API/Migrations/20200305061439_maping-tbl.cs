using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class mapingtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "ASSOCIATED_DOCUMENTS_TBL",
                columns: table => new
                {
                    DocumentId = table.Column<long>(nullable: false),
                    FormId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIATED_DOCUMENTS_TBL", x => new { x.FormId, x.DocumentId });
                    table.ForeignKey(
                        name: "FK_ASSOCIATED_DOCUMENTS_TBL_MD_DOCUMENT_TBL_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "MD_DOCUMENT_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ASSOCIATED_DOCUMENTS_TBL_MD_FORM_TBL_FormId",
                        column: x => x.FormId,
                        principalTable: "MD_FORM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

          
            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIATED_DOCUMENTS_TBL_DocumentId",
                table: "ASSOCIATED_DOCUMENTS_TBL",
                column: "DocumentId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASSOCIATED_DOCUMENTS_TBL");

         
        }
    }
}
