using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeWork.Migrations
{
    public partial class Designation12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "branch_id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "designation_id",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "updateDate",
                table: "AspNetUsers",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "AspNetUsers",
                newName: "Middle_name");

            migrationBuilder.RenameColumn(
                name: "linkedin",
                table: "AspNetUsers",
                newName: "Linkedin");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "AspNetUsers",
                newName: "Last_name");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "AspNetUsers",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "AspNetUsers",
                newName: "First_name");

            migrationBuilder.RenameColumn(
                name: "fb",
                table: "AspNetUsers",
                newName: "Fb");

            migrationBuilder.RenameColumn(
                name: "device_id",
                table: "AspNetUsers",
                newName: "Device_id");

            migrationBuilder.RenameColumn(
                name: "contact",
                table: "AspNetUsers",
                newName: "Contact");

            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "AspNetUsers",
                newName: "Company_id");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "AspNetUsers",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "AspNetUsers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "addeddate",
                table: "AspNetUsers",
                newName: "Addeddate");

            migrationBuilder.RenameColumn(
                name: "u_type",
                table: "AspNetUsers",
                newName: "UserType");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "AspNetUsers",
                newName: "MaritalStatus");

            migrationBuilder.RenameColumn(
                name: "blood_group",
                table: "AspNetUsers",
                newName: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "Middle_name",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Device_id",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Company_id",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesignationDate",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DesignationDate",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "AspNetUsers",
                newName: "updateDate");

            migrationBuilder.RenameColumn(
                name: "Middle_name",
                table: "AspNetUsers",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "Linkedin",
                table: "AspNetUsers",
                newName: "linkedin");

            migrationBuilder.RenameColumn(
                name: "Last_name",
                table: "AspNetUsers",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "First_name",
                table: "AspNetUsers",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "Fb",
                table: "AspNetUsers",
                newName: "fb");

            migrationBuilder.RenameColumn(
                name: "Device_id",
                table: "AspNetUsers",
                newName: "device_id");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "AspNetUsers",
                newName: "contact");

            migrationBuilder.RenameColumn(
                name: "Company_id",
                table: "AspNetUsers",
                newName: "company_id");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "AspNetUsers",
                newName: "bio");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Addeddate",
                table: "AspNetUsers",
                newName: "addeddate");

            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "AspNetUsers",
                newName: "u_type");

            migrationBuilder.RenameColumn(
                name: "MaritalStatus",
                table: "AspNetUsers",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "AspNetUsers",
                newName: "blood_group");

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "AspNetUsers",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "device_id",
                table: "AspNetUsers",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "company_id",
                table: "AspNetUsers",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "bio",
                table: "AspNetUsers",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "branch_id",
                table: "AspNetUsers",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "designation_id",
                table: "AspNetUsers",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0);
        }
    }
}
