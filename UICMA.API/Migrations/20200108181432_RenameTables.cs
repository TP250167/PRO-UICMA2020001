using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_SCHEDULE_TBL_ScheduleId1",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Users_UserId1",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULE_TBL_Users_CreatorId",
                table: "SCHEDULE_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULE_TBL_Users_ModifierId",
                table: "SCHEDULE_TBL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendees",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_ScheduleId1",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_UserId1",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "ScheduleId1",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Attendees");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "USER_TBL");

            migrationBuilder.RenameTable(
                name: "Attendees",
                newName: "ATTENDEE_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 23, 44, 32, 516, DateTimeKind.Local).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 8, 23, 16, 20, 970, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.AlterColumn<long>(
                name: "ModifiedBy",
                table: "SCHEDULE_TBL",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 23, 44, 32, 515, DateTimeKind.Local).AddTicks(2067),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 8, 23, 16, 20, 969, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "SCHEDULE_TBL",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "USER_TBL",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "ATTENDEE_TBL",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "ScheduleId",
                table: "ATTENDEE_TBL",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_USER_TBL",
                table: "USER_TBL",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ATTENDEE_TBL",
                table: "ATTENDEE_TBL",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ATTENDEE_TBL_ScheduleId",
                table: "ATTENDEE_TBL",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ATTENDEE_TBL_UserId",
                table: "ATTENDEE_TBL",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ATTENDEE_TBL_SCHEDULE_TBL_ScheduleId",
                table: "ATTENDEE_TBL",
                column: "ScheduleId",
                principalTable: "SCHEDULE_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ATTENDEE_TBL_USER_TBL_UserId",
                table: "ATTENDEE_TBL",
                column: "UserId",
                principalTable: "USER_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULE_TBL_USER_TBL_CreatorId",
                table: "SCHEDULE_TBL",
                column: "CreatorId",
                principalTable: "USER_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULE_TBL_USER_TBL_ModifierId",
                table: "SCHEDULE_TBL",
                column: "ModifierId",
                principalTable: "USER_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ATTENDEE_TBL_SCHEDULE_TBL_ScheduleId",
                table: "ATTENDEE_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_ATTENDEE_TBL_USER_TBL_UserId",
                table: "ATTENDEE_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULE_TBL_USER_TBL_CreatorId",
                table: "SCHEDULE_TBL");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULE_TBL_USER_TBL_ModifierId",
                table: "SCHEDULE_TBL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USER_TBL",
                table: "USER_TBL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ATTENDEE_TBL",
                table: "ATTENDEE_TBL");

            migrationBuilder.DropIndex(
                name: "IX_ATTENDEE_TBL_ScheduleId",
                table: "ATTENDEE_TBL");

            migrationBuilder.DropIndex(
                name: "IX_ATTENDEE_TBL_UserId",
                table: "ATTENDEE_TBL");

            migrationBuilder.RenameTable(
                name: "USER_TBL",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "ATTENDEE_TBL",
                newName: "Attendees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 23, 16, 20, 970, DateTimeKind.Local).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 8, 23, 44, 32, 516, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "SCHEDULE_TBL",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 23, 16, 20, 969, DateTimeKind.Local).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 8, 23, 44, 32, 515, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "SCHEDULE_TBL",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Attendees",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Attendees",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "ScheduleId1",
                table: "Attendees",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId1",
                table: "Attendees",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendees",
                table: "Attendees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_ScheduleId1",
                table: "Attendees",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_UserId1",
                table: "Attendees",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_SCHEDULE_TBL_ScheduleId1",
                table: "Attendees",
                column: "ScheduleId1",
                principalTable: "SCHEDULE_TBL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Users_UserId1",
                table: "Attendees",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULE_TBL_Users_CreatorId",
                table: "SCHEDULE_TBL",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULE_TBL_Users_ModifierId",
                table: "SCHEDULE_TBL",
                column: "ModifierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
