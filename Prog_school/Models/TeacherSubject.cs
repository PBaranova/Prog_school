using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_school.Models
{
    public class TeacherSubject : BaseClass
    {
        public long TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public long SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
