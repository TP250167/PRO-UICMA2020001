using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addBENEFITAUDITtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 870, DateTimeKind.Local).AddTicks(3003),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 951, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 888, DateTimeKind.Local).AddTicks(5490),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 968, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 765, DateTimeKind.Local).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 843, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 764, DateTimeKind.Local).AddTicks(2353),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 842, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 823, DateTimeKind.Local).AddTicks(9271),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 908, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 955, DateTimeKind.Local).AddTicks(2873),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 28, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 947, DateTimeKind.Local).AddTicks(996),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 20, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 951, DateTimeKind.Local).AddTicks(8004),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 25, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 940, DateTimeKind.Local).AddTicks(7877),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 14, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 811, DateTimeKind.Local).AddTicks(7344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 897, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 884, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 963, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 970, DateTimeKind.Local).AddTicks(918),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 43, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 785, DateTimeKind.Local).AddTicks(1301),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 862, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 787, DateTimeKind.Local).AddTicks(9279),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 867, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 835, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 920, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 955, DateTimeKind.Local).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 29, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 863, DateTimeKind.Local).AddTicks(5547),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 946, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 780, DateTimeKind.Local).AddTicks(7122),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 857, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 796, DateTimeKind.Local).AddTicks(8948),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 878, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 807, DateTimeKind.Local).AddTicks(6092),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 891, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 961, DateTimeKind.Local).AddTicks(765),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 34, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 817, DateTimeKind.Local).AddTicks(5985),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 903, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 832, DateTimeKind.Local).AddTicks(519),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 916, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 855, DateTimeKind.Local).AddTicks(8989),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 939, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 877, DateTimeKind.Local).AddTicks(2416),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 958, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.CreateTable(
                name: "BENEFIT_AUDIT_TBL",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLAIMANT_NAME = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    MAIL_DATE = table.Column<DateTime>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    FORM_CODE = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    MODIFIED_BY = table.Column<string>(nullable: true),
                    CREATED_ON = table.Column<DateTime>(nullable: true),
                    MODIFIED_ON = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 974, DateTimeKind.Local).AddTicks(6331)),
                    CLAIM_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BENEFIT_AUDIT_ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BENEFIT_AUDIT_TBL_CLAIM_TBL_CLAIM_ID",
                        column: x => x.CLAIM_ID,
                        principalTable: "CLAIM_TBL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BENEFIT_AUDIT_TBL_CLAIM_ID",
                table: "BENEFIT_AUDIT_TBL",
                column: "CLAIM_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BENEFIT_AUDIT_TBL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 951, DateTimeKind.Local).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 870, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 968, DateTimeKind.Local).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 888, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 843, DateTimeKind.Local).AddTicks(778),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 765, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 842, DateTimeKind.Local).AddTicks(2206),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 764, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 908, DateTimeKind.Local).AddTicks(8822),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 823, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 28, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 955, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 20, DateTimeKind.Local).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 947, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 25, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 951, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 14, DateTimeKind.Local).AddTicks(5039),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 940, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 897, DateTimeKind.Local).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 811, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 963, DateTimeKind.Local).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 884, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTICE_OF_HEARING_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 43, DateTimeKind.Local).AddTicks(9733),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 970, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 862, DateTimeKind.Local).AddTicks(6099),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 785, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 867, DateTimeKind.Local).AddTicks(5152),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 787, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 920, DateTimeKind.Local).AddTicks(3700),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 835, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "FORM_DOCUMENT_MAP_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 29, DateTimeKind.Local).AddTicks(884),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 955, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 946, DateTimeKind.Local).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 863, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 857, DateTimeKind.Local).AddTicks(3826),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 780, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 878, DateTimeKind.Local).AddTicks(1699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 796, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 891, DateTimeKind.Local).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 807, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_EXCEPTION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 39, 34, DateTimeKind.Local).AddTicks(2889),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 961, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 903, DateTimeKind.Local).AddTicks(8227),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 817, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 916, DateTimeKind.Local).AddTicks(1808),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 832, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 939, DateTimeKind.Local).AddTicks(6980),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 855, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 12, 11, 31, 38, 958, DateTimeKind.Local).AddTicks(1240),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 12, 11, 40, 41, 877, DateTimeKind.Local).AddTicks(2416));
        }
    }
}
