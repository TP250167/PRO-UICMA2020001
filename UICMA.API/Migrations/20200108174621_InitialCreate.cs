using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULE_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false, defaultValue: 3),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    CreatorId = table.Column<long>(nullable: true),
                    ModifierId = table.Column<long>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 8, 23, 16, 20, 969, DateTimeKind.Local).AddTicks(7780)),
                    ModifiedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 8, 23, 16, 20, 970, DateTimeKind.Local).AddTicks(9984))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULE_TBL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SCHEDULE_TBL_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SCHEDULE_TBL_Users_ModifierId",
                        column: x => x.ModifierId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<long>(nullable: true),
                    ScheduleId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendees_SCHEDULE_TBL_ScheduleId1",
                        column: x => x.ScheduleId1,
                        principalTable: "SCHEDULE_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendees_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_ScheduleId1",
                table: "Attendees",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_UserId1",
                table: "Attendees",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_SCHEDULE_TBL_CreatorId",
                table: "SCHEDULE_TBL",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SCHEDULE_TBL_ModifierId",
                table: "SCHEDULE_TBL",
                column: "ModifierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "SCHEDULE_TBL");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
