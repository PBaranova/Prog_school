

using Microsoft.EntityFrameworkCore;

namespace Prog_school.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Quarter> Quarters { get; set; }
        public DbSet<SubjectStudentGrade> SubjectStudentGrades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=senale127;Server=localhost;Port=5432;Database=School;Search Path=public; Integrated Security=true;Pooling=true;");
        }
    }
}
