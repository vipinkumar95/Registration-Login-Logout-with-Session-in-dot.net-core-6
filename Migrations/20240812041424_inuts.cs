using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loginwithsession.Migrations
{
    public partial class inuts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Logins");
        }
    }
}
