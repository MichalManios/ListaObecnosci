using Microsoft.EntityFrameworkCore.Migrations;

namespace Lista_obecności.Data.Migrations
{
    public partial class AddingUsersToApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sBirthdayDate",
                table: "AspNetUsers",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sEmailAddress",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sPassword",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sBirthdayDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sEmailAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sPassword",
                table: "AspNetUsers");
        }
    }
}
