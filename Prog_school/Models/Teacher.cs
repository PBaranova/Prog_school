using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_school.Models
{
    public class Teacher : BaseClass
    {
        public string Login { get; set; }
        public string Password { get; set; }
        //Имя
        public string TeacherFIO { get; set; }
        //предметы которые ведет препод 
        public List<TeacherSubject> Subjects { get; set; }
        // кабинет, который принадлежит преподу
        public long CabinetId { get; set; }
        public Cabinet Cabinet { get; set; }
    }
}
