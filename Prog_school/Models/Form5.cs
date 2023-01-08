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
    public partial class Form5 : Form
    {
        private Form3 StudentForm;
        public Form5(Form3 studentForm)
        {
            StudentForm = studentForm;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            FillBoxes();
        }
        private void FillBoxes()
        {
            using (AppDbContext dbContext = new AppDbContext()) {
                var subjects = dbContext.Subjects.ToList();
                var classes = dbContext.Classes.ToList();

                studentSubjectsList.ValueMember = "Id";
                studentSubjectsList.DisplayMember = "Name";
                studentSubjectsList.DataSource = subjects;
                studentClass.ValueMember = "Id";
                studentClass.DisplayMember= "Name";
                studentClass.DataSource = classes;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedSubjects = studentSubjectsList.SelectedItems;
            var selectedClass = studentClass.SelectedItem as Class;

            using (AppDbContext dbContext = new AppDbContext())
            {

                var student = new Student()
                {
                    StudentFIO = textBox2.Text,
                    ClassId = selectedClass.Id
                };
                dbContext.Students.Add(student);

                foreach (var subject in selectedSubjects)
                {
                    dbContext.StudentSubjects.Add(new StudentSubject()
                    {
                        SubjectId = (subject as Subject).Id,
                        Student = student
                    });
                }
                var result = dbContext.SaveChanges() > 0;

                if (result)
                {
                    MessageBox.Show("Студент успешно добавлен");
                    StudentForm.FillTable();
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка добаления студента");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
