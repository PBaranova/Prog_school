using Prog_school.TablesData;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addStudentForm = new Form5(this);
            addStudentForm.ShowDialog();
        }
        public void FillTable()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var students = dbContext.Students.Select(t => new Student()
                {
                    Id = t.Id,
                    StudentFIO = t.StudentFIO,
                    Subjects = t.Subjects.ToList().Select(r => new StudentSubject() { Subject = new Subject() { Name = r.Subject.Name } }).ToList(),
                    Class = t.Class
                }).ToList();
                var tableStudents = new List<StudentTableData>(students.Count);
                students.ForEach(t =>
                {
                    var tableStudent = new StudentTableData()
                    {
                        Id = t.Id,
                        StudentFIO = t.StudentFIO,
                        ClassName = $"{t.Class.Name}",
                        SubjectsNames = string.Empty,
                    };

                    t.Subjects.ForEach(s => tableStudent.SubjectsNames += $"{s.Subject.Name}, ");
                    tableStudents.Add(tableStudent);
                });
                dataGridView1.DataSource = tableStudents;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                for (int index = 0; index < dataGridView1.SelectedRows.Count; index++)
                {
                    var selectedRow = dataGridView1.SelectedRows[index];
                    var removedTeacher = (StudentTableData)selectedRow.DataBoundItem;
                    dbContext.Students.Remove(new Student() { Id = removedTeacher.Id });
                    //pilots.Add(pilot);
                }
                var result = dbContext.SaveChanges() > 0;
                if (result)
                {
                    MessageBox.Show("Выбранные студенты успешно отчислены");
                    FillTable();
                }
                else
                    MessageBox.Show("Ошибка отчисления выбранных студентов");

            }
        }
    }
}
