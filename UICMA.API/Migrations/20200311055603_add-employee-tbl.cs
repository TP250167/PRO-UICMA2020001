using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addemployeetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 248, DateTimeKind.Local).AddTicks(6062),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 679, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 259, DateTimeKind.Local).AddTicks(7588),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 690, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 178, DateTimeKind.Local).AddTicks(2448),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 607, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 177, DateTimeKind.Local).AddTicks(2678),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 606, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 224, DateTimeKind.Local).AddTicks(8764),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 655, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 293, DateTimeKind.Local).AddTicks(4383),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 726, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 286, DateTimeKind.Local).AddTicks(3354),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 717, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 288, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 719, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 282, DateTimeKind.Local).AddTicks(3861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 713, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 215, DateTimeKind.Local).AddTicks(7047),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 644, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 256, DateTimeKind.Local).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 687, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 193, DateTimeKind.Local).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 622, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 195, DateTimeKind.Local).AddTicks(8839),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 625, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 232, DateTimeKind.Local).AddTicks(9718),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 663, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 244, DateTimeKind.Local).AddTicks(2197),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 674, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 190, DateTimeKind.Local).AddTicks(1190),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 619, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 203, DateTimeKind.Local).AddTicks(7136),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 632, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 211, DateTimeKind.Local).AddTicks(9558),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 640, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 221, DateTimeKind.Local).AddTicks(102),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 651, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 230, DateTimeKind.Local).AddTicks(1994),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 660, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 239, DateTimeKind.Local).AddTicks(6525),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 669, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 253, DateTimeKind.Local).AddTicks(615),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 683, DateTimeKind.Local).AddTicks(5961));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "WAGES_AFTER_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 679, DateTimeKind.Local).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 248, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "TEMPLATE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 690, DateTimeKind.Local).AddTicks(709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 259, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 607, DateTimeKind.Local).AddTicks(7517),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 178, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SCHEDULE_TBL",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 606, DateTimeKind.Local).AddTicks(9113),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 177, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RESPONSE_TO_EMPLOYER_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 655, DateTimeKind.Local).AddTicks(1734),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 224, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_SCHEDULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 726, DateTimeKind.Local).AddTicks(3877),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 293, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 717, DateTimeKind.Local).AddTicks(815),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 286, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_RECIPIENT_RULE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 719, DateTimeKind.Local).AddTicks(9479),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 288, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "RA_BATCH_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 713, DateTimeKind.Local).AddTicks(3201),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 282, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "QUESTIONS_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 644, DateTimeKind.Local).AddTicks(1996),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 215, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "NOTIFICATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 687, DateTimeKind.Local).AddTicks(2392),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 256, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_FORM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 622, DateTimeKind.Local).AddTicks(6550),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 193, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "MD_DOCUMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 625, DateTimeKind.Local).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 195, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ISSUES_LIST_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 663, DateTimeKind.Local).AddTicks(4096),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 232, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CUIAB_ACKNOWLEDGEMENT_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 674, DateTimeKind.Local).AddTicks(3907),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 244, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 619, DateTimeKind.Local).AddTicks(6491),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 190, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_RESPONSE_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 632, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 203, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_INTERVIEW_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 640, DateTimeKind.Local).AddTicks(3027),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 211, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_DETERMINATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 651, DateTimeKind.Local).AddTicks(4981),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 221, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "CLAIM_APPEAL_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 660, DateTimeKind.Local).AddTicks(7643),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 230, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ALJ_DECISION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 669, DateTimeKind.Local).AddTicks(9915),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 239, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MODIFIED_ON",
                table: "ADDITIONAL_INFORMATION_TBL",
                nullable: true,
                defaultValue: new DateTime(2020, 3, 11, 9, 53, 8, 683, DateTimeKind.Local).AddTicks(5961),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 3, 11, 11, 26, 3, 253, DateTimeKind.Local).AddTicks(615));
        }
    }
}
