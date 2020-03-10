using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class add_template_notification_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "NOTIFICATION_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOTIFY_ATTACHMENT = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NOTIFY_TO = table.Column<string>(nullable: true),
                    NOTIFY_CC = table.Column<string>(nullable: true),
                    NOTIFY_BCC = table.Column<string>(nullable: true),
                    NOTIFY_FROM = table.Column<string>(nullable: true),
                    NOTIFY_SUBJECT = table.Column<string>(nullable: true),
                    NOTIFY_BODY = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 10, 15, 35, 39, 229, DateTimeKind.Local).AddTicks(9296)),
                    NOTIFY_STATUS = table.Column<string>(nullable: true),
                    REQUEST_TYPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NOTIFY_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TEMPLATE_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 10, 15, 35, 39, 232, DateTimeKind.Local).AddTicks(8994)),
                    TEMPLATE_NAME = table.Column<string>(nullable: true),
                    TEMPLATE_CATEGORY = table.Column<string>(nullable: true),
                    TEMPLATE_STATUS = table.Column<string>(nullable: true),
                    TEMPLATE_BODY_CONTENT = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    TEMPLATE_TYPE = table.Column<string>(nullable: true),
                    TEMPLATE_DESCRIPTION = table.Column<string>(nullable: true),
                    TEMPLATE_ATTACHMENT_CONTENT = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    LETTER_TYPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TEMPLATE_ID", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NOTIFICATION_TBL");

            migrationBuilder.DropTable(
                name: "TEMPLATE_TBL");

           
        }
    }
}
