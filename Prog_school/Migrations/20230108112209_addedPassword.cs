using Microsoft.EntityFrameworkCore.Migrations;

namespace Prog_school.Migrations
{
    public partial class addedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Teachers");
        }
    }
}
