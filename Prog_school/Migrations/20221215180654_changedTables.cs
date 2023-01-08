using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Prog_school.Migrations
{
    public partial class changedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_StudentId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_StudentId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Gradeld",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Quarter",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Quarterld",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Student",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Studentld",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "Subjectld",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Students");

            migrationBuilder.AddColumn<long>(
                name: "GradeId",
                table: "SubjectStudentGrades",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "QuarterId",
                table: "SubjectStudentGrades",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "SubjectStudentGrades",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StudentSubjectId",
                table: "SubjectStudentGrades",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClassId",
                table: "Students",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<long>(nullable: false),
                    SubjectId = table.Column<long>(nullable: false),
                    Subject = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<long>(nullable: false),
                    SubjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectStudentGrades_GradeId",
                table: "SubjectStudentGrades",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectStudentGrades_QuarterId",
                table: "SubjectStudentGrades",
                column: "QuarterId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectStudentGrades_StudentId",
                table: "SubjectStudentGrades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectStudentGrades_StudentSubjectId",
                table: "SubjectStudentGrades",
                column: "StudentSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentId",
                table: "StudentSubjects",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_SubjectId",
                table: "TeacherSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_TeacherId",
                table: "TeacherSubjects",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectStudentGrades_Grades_GradeId",
                table: "SubjectStudentGrades",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectStudentGrades_Quarters_QuarterId",
                table: "SubjectStudentGrades",
                column: "QuarterId",
                principalTable: "Quarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectStudentGrades_Students_StudentId",
                table: "SubjectStudentGrades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectStudentGrades_StudentSubjects_StudentSubjectId",
                table: "SubjectStudentGrades",
                column: "StudentSubjectId",
                principalTable: "StudentSubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectStudentGrades_Grades_GradeId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectStudentGrades_Quarters_QuarterId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectStudentGrades_Students_StudentId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectStudentGrades_StudentSubjects_StudentSubjectId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.DropIndex(
                name: "IX_SubjectStudentGrades_GradeId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_SubjectStudentGrades_QuarterId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_SubjectStudentGrades_StudentId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_SubjectStudentGrades_StudentSubjectId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "QuarterId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "StudentSubjectId",
                table: "SubjectStudentGrades");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Students");

            migrationBuilder.AddColumn<long>(
                name: "Grade",
                table: "SubjectStudentGrades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Gradeld",
                table: "SubjectStudentGrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Quarter",
                table: "SubjectStudentGrades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Quarterld",
                table: "SubjectStudentGrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student",
                table: "SubjectStudentGrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Studentld",
                table: "SubjectStudentGrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "SubjectStudentGrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subjectld",
                table: "SubjectStudentGrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "Subjects",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TeacherId",
                table: "Subjects",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "GradeId",
                table: "Students",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudentId",
                table: "Subjects",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_StudentId",
                table: "Subjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
