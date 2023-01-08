using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_school.Models
{
    public partial class Form7 : Form
    {
        private Form4 teachersForm;
        public Form7(Form4 teachersForm)
        {
            this.teachersForm = teachersForm;
            InitializeComponent();
            fillBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedSubjects = subjectsListBox.SelectedItems;
            var selectedCabinet = cabinetListBox.SelectedItem as Cabinet;

            using (AppDbContext dbContext =  new AppDbContext())
            {

                var teacher = new Teacher()
                {
                    TeacherFIO = teacherFIO.Text,
                    CabinetId = selectedCabinet.Id,
                };
                dbContext.Teachers.Add(teacher);

                foreach(var subject  in selectedSubjects)
                {
                    dbContext.TeacherSubjects.Add(new TeacherSubject()
                    {
                        SubjectId = (subject as Subject).Id,
                        Teacher = teacher
                    });
                }
                var result = dbContext.SaveChanges() > 0;

                if (result)
                {
                    MessageBox.Show("Учитель успешно добавлен");
                    teachersForm.FillTable();
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка добаления учителя");
            }
                
            //selectedSubjects.
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void fillBoxes ()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var subjects = dbContext.Subjects.ToList();
                var cabinets = dbContext.Cabinets.ToList();
                cabinetListBox.ValueMember = "Id";
                cabinetListBox.DisplayMember = "Name";
                cabinetListBox.DataSource = cabinets;
                subjectsListBox.ValueMember = "Id";
                subjectsListBox.DisplayMember = "Name";
                subjectsListBox.DataSource = subjects;
                //subjectListBox.
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = subjectsListBox.SelectedItem;
        }
    }
}
