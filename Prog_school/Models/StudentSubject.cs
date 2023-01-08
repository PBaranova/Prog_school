using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_school.Models
{
    public class StudentSubject : BaseClass
    {
        public long StudentId { get; set; }
        public Student Student { get; set; }
        public long SubjectId { get; set; }
        public long Subject { get; set; }
        public List<SubjectStudentGrade> subjectStudentGrades { get; set; }
    }
}
