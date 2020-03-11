using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addALLRAtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "RA_BATCH_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BATCH_NAME = table.Column<string>(nullable: true),
                    BATCH_DESCRIPTION = table.Column<string>(nullable: true),
                    FREQUENCY = table.Column<string>(nullable: true),
                    IS_RECURING = table.Column<bool>(nullable: false, defaultValue: false),
                    OCCURRANCE = table.Column<string>(nullable: true),
                    STATUS = table.Column<string>(nullable: true),
                    TIME = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 713, DateTimeKind.Local).AddTicks(3201)),
                    NEXT_OCCURRANCE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_BATCH_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RA_RECIPIENT_RULE_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 719, DateTimeKind.Local).AddTicks(9479)),
                    RECIPIENT_RULE_NAME = table.Column<string>(nullable: true),
                    RECIPIENT_RULE_STATUS = table.Column<string>(nullable: true),
                    RECIPIENT_RULE_TYPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_RECIPIENT_RULE_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RA_RECIPIENT_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EMPLOYEE_NUMBER = table.Column<string>(nullable: true),
                    EMPLOYEE_NAME = table.Column<string>(nullable: true),
                    EMPLOYEE_EMAIL = table.Column<string>(nullable: true),
                    EMAIL_REFERENCE_NUMBER = table.Column<string>(nullable: true),
                    STATUS = table.Column<string>(nullable: true),
                    NOTIFIED_SENT_ON = table.Column<DateTime>(nullable: true),
                    DELIVERED_ON = table.Column<DateTime>(nullable: true),
                    FAILED_ON = table.Column<DateTime>(nullable: true),
                    DELIVERY_NOTICE = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 717, DateTimeKind.Local).AddTicks(815)),
                    RetrySucess = table.Column<int>(nullable: true),
                    RetryFail = table.Column<int>(nullable: true),
                    IS_RETRY = table.Column<bool>(nullable: false, defaultValue: false),
                    IS_SUCESSFULLY_DELIVER = table.Column<bool>(nullable: false, defaultValue: false),
                    IS_DELIVERY_MAIL_CAPTURED = table.Column<bool>(nullable: false, defaultValue: false),
                    IS_SENT_MAIL_CAPTURED = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_RECIPIENT_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RA_SCHEDULE_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CREATED_BY = table.Column<string>(nullable: true),
                    TOTAL_RECIPIENT = table.Column<int>(nullable: true),
                    SUCESSFUL_DELIVERY = table.Column<int>(nullable: true),
                    FAILED_DELIVERY = table.Column<int>(nullable: true),
                    SCHEDULE_DATE = table.Column<DateTime>(nullable: true),
                    STATUS = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 726, DateTimeKind.Local).AddTicks(3877))
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_SCHEDULE_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RA_BATCH_SCHEDULE_MAP_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BATCH_ID = table.Column<long>(nullable: false),
                    SCHEDULE_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_BATCH_SCHEDULE_MAP_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_SCHEDULE_MAP_TBL_RA_BATCH_TBL_BATCH_ID",
                        column: x => x.BATCH_ID,
                        principalTable: "RA_BATCH_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_SCHEDULE_MAP_TBL_SCHEDULE_TBL_SCHEDULE_ID",
                        column: x => x.SCHEDULE_ID,
                        principalTable: "SCHEDULE_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RA_BATCH_TEMPLATE_MAP_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BATCH_ID = table.Column<long>(nullable: false),
                    TEMPLATE_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_BATCH_TEMPLATE_MAP_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_TEMPLATE_MAP_TBL_RA_BATCH_TBL_BATCH_ID",
                        column: x => x.BATCH_ID,
                        principalTable: "RA_BATCH_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_TEMPLATE_MAP_TBL_TEMPLATE_TBL_TEMPLATE_ID",
                        column: x => x.TEMPLATE_ID,
                        principalTable: "TEMPLATE_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RA_BATCH_RECIP_RULE_MAP_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BATCH_ID = table.Column<long>(nullable: false),
                    RECIPIENT_RULE_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_BATCH_RECIP_RULE_MAP_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_RECIP_RULE_MAP_TBL_RA_BATCH_TBL_BATCH_ID",
                        column: x => x.BATCH_ID,
                        principalTable: "RA_BATCH_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_RECIP_RULE_MAP_TBL_RA_RECIPIENT_RULE_TBL_RECIPIENT_RULE_ID",
                        column: x => x.RECIPIENT_RULE_ID,
                        principalTable: "RA_RECIPIENT_RULE_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RA_ASSOCIATED_DOCUMENT_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TYPE = table.Column<string>(nullable: true),
                    DOCUMENTATION_PATH = table.Column<string>(nullable: true),
                    SCHEDULE_ID = table.Column<long>(nullable: false),
                    RECIPIENT_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_ASSOCIATED_DOCUMENT_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RA_ASSOCIATED_DOCUMENT_TBL_RA_RECIPIENT_TBL_RECIPIENT_ID",
                        column: x => x.RECIPIENT_ID,
                        principalTable: "RA_RECIPIENT_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RA_ASSOCIATED_DOCUMENT_TBL_SCHEDULE_TBL_SCHEDULE_ID",
                        column: x => x.SCHEDULE_ID,
                        principalTable: "SCHEDULE_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RA_BATCH_RECIPIENT_MAP_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BATCH_ID = table.Column<long>(nullable: false),
                    RECIPIENT_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RA_BATCH_RECIPIENT_MAP_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_RECIPIENT_MAP_TBL_RA_BATCH_TBL_BATCH_ID",
                        column: x => x.BATCH_ID,
                        principalTable: "RA_BATCH_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RA_BATCH_RECIPIENT_MAP_TBL_RA_RECIPIENT_TBL_RECIPIENT_ID",
                        column: x => x.RECIPIENT_ID,
                        principalTable: "RA_RECIPIENT_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RA_ASSOCIATED_DOCUMENT_TBL_RECIPIENT_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                column: "RECIPIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_ASSOCIATED_DOCUMENT_TBL_SCHEDULE_ID",
                table: "RA_ASSOCIATED_DOCUMENT_TBL",
                column: "SCHEDULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_RECIP_RULE_MAP_TBL_BATCH_ID",
                table: "RA_BATCH_RECIP_RULE_MAP_TBL",
                column: "BATCH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_RECIP_RULE_MAP_TBL_RECIPIENT_RULE_ID",
                table: "RA_BATCH_RECIP_RULE_MAP_TBL",
                column: "RECIPIENT_RULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_RECIPIENT_MAP_TBL_BATCH_ID",
                table: "RA_BATCH_RECIPIENT_MAP_TBL",
                column: "BATCH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_RECIPIENT_MAP_TBL_RECIPIENT_ID",
                table: "RA_BATCH_RECIPIENT_MAP_TBL",
                column: "RECIPIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_SCHEDULE_MAP_TBL_BATCH_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                column: "BATCH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_SCHEDULE_MAP_TBL_SCHEDULE_ID",
                table: "RA_BATCH_SCHEDULE_MAP_TBL",
                column: "SCHEDULE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_TEMPLATE_MAP_TBL_BATCH_ID",
                table: "RA_BATCH_TEMPLATE_MAP_TBL",
                column: "BATCH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RA_BATCH_TEMPLATE_MAP_TBL_TEMPLATE_ID",
                table: "RA_BATCH_TEMPLATE_MAP_TBL",
                column: "TEMPLATE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RA_ASSOCIATED_DOCUMENT_TBL");

            migrationBuilder.DropTable(
                name: "RA_BATCH_RECIP_RULE_MAP_TBL");

            migrationBuilder.DropTable(
                name: "RA_BATCH_RECIPIENT_MAP_TBL");

            migrationBuilder.DropTable(
                name: "RA_BATCH_SCHEDULE_MAP_TBL");

            migrationBuilder.DropTable(
                name: "RA_BATCH_TEMPLATE_MAP_TBL");

            migrationBuilder.DropTable(
                name: "RA_SCHEDULE_TBL");

            migrationBuilder.DropTable(
                name: "RA_RECIPIENT_RULE_TBL");

            migrationBuilder.DropTable(
                name: "RA_RECIPIENT_TBL");

            migrationBuilder.DropTable(
                name: "RA_BATCH_TBL");
        
        }
    }
}
