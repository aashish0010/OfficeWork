using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeWork.Migrations
{
    public partial class datetime1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updateDate",
                table: "department",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "headid",
                table: "department",
                newName: "Headid");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "department",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "companyid",
                table: "department",
                newName: "Companyid");

            migrationBuilder.RenameColumn(
                name: "clientid",
                table: "department",
                newName: "Clientid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "department",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "department",
                newName: "updateDate");

            migrationBuilder.RenameColumn(
                name: "Headid",
                table: "department",
                newName: "headid");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "department",
                newName: "createdDate");

            migrationBuilder.RenameColumn(
                name: "Companyid",
                table: "department",
                newName: "companyid");

            migrationBuilder.RenameColumn(
                name: "Clientid",
                table: "department",
                newName: "clientid");

            migrationBuilder.AlterColumn<string>(
                name: "updateDate",
                table: "department",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
