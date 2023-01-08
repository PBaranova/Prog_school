using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_school.Models
{
    public class Student: BaseClass
    {
        public string StudentFIO { get; set; } 
        public long ClassId { get; set; }
        public Class Class { get; set; }
        //в каком классе учится
        public List<StudentSubject> Subjects { get; set; }
        // оценка, которая принадлежит ученику
        //public long GradeId { get; set; }
        //public Grade Grade { get; set; }
        public List<SubjectStudentGrade> SubjectStudentGrades { get; set; }
    }
}
