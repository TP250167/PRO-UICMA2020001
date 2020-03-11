using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UICMA.API.Migrations
{
    public partial class addemployeetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "EMPLOYEE_TBL",
                columns: table => new
                {
                    EMP_NUM_CODE = table.Column<string>(nullable: false),
                    LAST_NAME = table.Column<string>(nullable: true),
                    MIDDLE_NAME = table.Column<string>(nullable: true),
                    FIRST_NAME = table.Column<string>(nullable: true),
                    INITIAL_NAME = table.Column<string>(name: "INITIAL_NAME,", nullable: true),
                    BIRTH_DAY = table.Column<DateTime>(nullable: true),
                    BIRTH_DATE = table.Column<string>(nullable: true),
                    BIRTH_YEAR = table.Column<string>(nullable: true),
                    BIRTH_MONTH = table.Column<string>(nullable: true),
                    TITLE_NAME = table.Column<string>(nullable: true),
                    SECOND_TITLE_NAME = table.Column<string>(nullable: true),
                    OTHER_TITLE_NAME = table.Column<string>(nullable: true),
                    SECOND_NAME = table.Column<string>(nullable: true),
                    TIE_BREAKER = table.Column<string>(nullable: true),
                    GENDER_IND = table.Column<string>(nullable: true),
                    LANGUAGE_IND = table.Column<string>(nullable: true),
                    ETHNICITY_CODE = table.Column<string>(nullable: true),
                    ETHNICITY_DESCR = table.Column<string>(nullable: true),
                    HOUSE_NUM_STREET_ADDR = table.Column<string>(nullable: true),
                    CITY_NAME = table.Column<string>(nullable: true),
                    POSTAL_CODE = table.Column<string>(nullable: true),
                    REGION_CODE = table.Column<string>(nullable: true),
                    COUNTRY_ISO_CODE = table.Column<string>(nullable: true),
                    TELEPHONE_NUMBER = table.Column<string>(nullable: true),
                    SOCIAL_SECURITY_NUMBER = table.Column<string>(nullable: true),
                    SEID_CODE = table.Column<string>(nullable: true),
                    HIGHEST_DEGREE_CODE = table.Column<string>(nullable: true),
                    HIGHEST_DEGREE_NAME = table.Column<string>(nullable: true),
                    OID_EMAIL_ADDRESS = table.Column<string>(nullable: true),
                    SAP_USER_ID_CODE = table.Column<string>(nullable: true),
                    SAP_EMAIL_ADDRESS = table.Column<string>(nullable: true),
                    EMP_TYPE_CODE = table.Column<string>(nullable: true),
                    CREATE_DATE = table.Column<DateTime>(nullable: true),
                    ACTIVE_EMPLOYEE_INDICATOR = table.Column<string>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    LAST_UPDATE_DATE = table.Column<DateTime>(nullable: true),
                    LAST_UPDATED_BY = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE_TBL", x => x.EMP_NUM_CODE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMPLOYEE_TBL");

           
        }
    }
}
