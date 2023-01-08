using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_school.Models
{
    public class Subject : BaseClass
    {
        //Название предмета
        public string Name { get; set; }
        public List<TeacherSubject> Teachers { get; set; }

        //public long TeacherId { get; set; }
        //public Teacher Teacher { get; set; }

  
    }
}
