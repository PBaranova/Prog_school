using Microsoft.EntityFrameworkCore.Migrations;

namespace Prog_school.Migrations
{
    public partial class changedStudentFIO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentFIO",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentFIO",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Students",
                type: "text",
                nullable: true);
        }
    }
}
