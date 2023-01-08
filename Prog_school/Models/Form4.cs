using Microsoft.EntityFrameworkCore;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addTeacherForm = new Form7(this);
            addTeacherForm.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (AppDbContext dbContext = new AppDbContext())
            {
                for (int index = 0; index < dataGridView1.SelectedRows.Count; index++)
                {
                    var selectedRow = dataGridView1.SelectedRows[index];
                    var removedTeacher = (TeacherTableData)selectedRow.DataBoundItem;
                    dbContext.Teachers.Remove(new Teacher() { Id = removedTeacher.Id });
                    //pilots.Add(pilot);
                }
                var result = dbContext.SaveChanges() > 0;
                if (result)
                {
                    MessageBox.Show("Выбранные учителя успешно удалены");
                    FillTable();
                }
                else
                    MessageBox.Show("Ошибка удаления выбранных учителей");
              
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FillTable();
        }
        public void FillTable ()
        {
            using (AppDbContext dbContext =  new AppDbContext())
            {
                var teachers = dbContext.Teachers.Select(t=> new Teacher()
                {
                    Id = t.Id,
                    TeacherFIO = t.TeacherFIO,
                    Subjects = t.Subjects.ToList().Select(r=> new TeacherSubject() { Subject = new Subject () {  Name = r.Subject.Name} }).ToList(),
                    Cabinet = t.Cabinet 
                }).ToList();
                var tableTeachers = new List<TeacherTableData>();
                teachers.ForEach(t =>
                {
                    var tableTeacher = new TeacherTableData()
                    {
                        Id = t.Id,
                        TeacherFIO = t.TeacherFIO,
                        CabinetName = $"{t.Cabinet.Name} №{t.Cabinet.Number}",
                        SubjectsNames = string.Empty,
                    };

                    t.Subjects.ForEach(s => tableTeacher.SubjectsNames +=  $"{s.Subject.Name}, ");
                    tableTeachers.Add(tableTeacher);
                });
                dataGridView1.DataSource = tableTeachers;
            }
        }
    }
}
