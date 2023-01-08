using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_school.Models
{
    public class SubjectStudentGrade : BaseClass
    {
        public long StudentSubjectId { get; set; }
        public StudentSubject StudentSubject { get; set; }
        public long GradeId { get; set; }
        public Grade Grade { get; set; }
        //Четверть
        public long QuarterId { get; set; }
        public Quarter Quarter { get; set; }

    }
}

     