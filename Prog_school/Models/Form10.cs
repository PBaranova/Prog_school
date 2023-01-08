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
    public partial class Form10 : Form
    {
        private readonly AppDbContext _context;
        public Form10()
        {
            _context = new AppDbContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addGradeForm = new Form9(this);
            addGradeForm.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            FillTable();
        }
        public void FillTable ()
        {
            var subjectGrades = _context.SubjectStudentGrades.Where(g => 
                                                                    (string.IsNullOrEmpty(subjectNameSeach.Text) ||  g.StudentSubject.Subject.Name.ToUpper().Contains(subjectNameSeach.Text.ToUpper())) &&
                                                                    (string.IsNullOrEmpty(studentFIOSearch.Text) || g.StudentSubject.Student.StudentFIO.ToUpper().Contains(studentFIOSearch.Text.ToUpper())) &&
                                                                    (string.IsNullOrEmpty(searchClass.Text) || g.StudentSubject.Student.Class.Name.ToUpper().Contains(searchClass.Text.ToUpper()))
                                                                    ).Select(g => new SubjectGradesTableData()
                                                                    {
                                                                        ClassName = g.StudentSubject.Student.Class.Name,
                                                                        Grade = g.Grade.Number,
                                                                        QuarterName = $"{g.Quarter.Quarterinf}, год {g.Quarter.Year}",
                                                                        StudentName = g.StudentSubject.Student.StudentFIO,
                                                                        SubjectName = g.StudentSubject.Subject.Name,
                                                                    }
                                                                    ).ToList();
            dataGridView1.DataSource = subjectGrades;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
