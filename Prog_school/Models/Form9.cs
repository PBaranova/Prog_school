using Microsoft.EntityFrameworkCore;
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
    public partial class Form9 : Form
    {
        private readonly AppDbContext _context;
        private readonly Form10 subjectGradesForm;
        public Form9(Form10 form10)
        {
            subjectGradesForm = form10;
            _context = new AppDbContext();
           
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            FillGradeList();
            FillStudentBox(string.Empty);
            FillQuartersList();

            //subjectNameList.
        }
        private void FillStudentBox(string name)
        {
            var students = _context.Students.Include(s => s.Class).Where(s => string.IsNullOrEmpty(name) || s.StudentFIO.ToUpper().Contains(name.ToUpper()) || s.Class.Name.ToUpper().Contains(name.ToUpper())).ToList();
            //students.ForEach(s => s.StudentFIO += $" {s.Class.Name}");
            studentList.ValueMember = "Id";
            studentList.DisplayMember = "StudentFIO";
            studentList.DataSource = students;
        }
        private void FillSubjectsBox(long studentId)
        {
            var subjects =  _context.StudentSubjects.Where(s=> s.StudentId == studentId).Select(r=> r.Subject).ToList();
            subjectNameList.ValueMember = "Id";
            subjectNameList.DisplayMember = "Name";
            subjectNameList.DataSource = subjects;
        }
        private void FillQuartersList()
        {
            var quarters = _context.Quarters.ToList();
            quarters.ForEach(q => q.Quarterinf += $" год: {q.Year}");
            quarterList.ValueMember = "Id";
            quarterList.DisplayMember = "Quarterinf";
            quarterList.DataSource = quarters;
        }
        private void FillGradeList()
        {
            var grades = _context.Grades.ToList();
            gradeList.ValueMember = "Id";
            gradeList.DisplayMember = "Number";
            gradeList.DataSource = grades;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedSubject =  subjectNameList.SelectedItem as Subject;
            var selectedStudent = studentList.SelectedItem as Student;
            var selectedQuarter = quarterList.SelectedItem as Quarter;
            var selectedGrade = gradeList.SelectedItem as Grade;
            var subjectStudentGrade = new SubjectStudentGrade()
            {
                StudentSubjectId = _context.StudentSubjects.Where(s => s.SubjectId == selectedSubject.Id && s.StudentId == selectedStudent.Id).Select(r => r.Id).FirstOrDefault(),
                QuarterId = selectedQuarter.Id,
                GradeId = selectedGrade.Id,
            };
            var existGrades = _context.SubjectStudentGrades.Where(r => r.QuarterId == subjectStudentGrade.QuarterId && r.StudentSubjectId == subjectStudentGrade.StudentSubjectId).ToList();
            if (existGrades != null && existGrades.Count > 0)
                _context.SubjectStudentGrades.RemoveRange(existGrades);

            _context.SubjectStudentGrades.Add(subjectStudentGrade);
            var result = _context.SaveChanges() >0 ;
            if (result)
            {
                subjectGradesForm.FillTable();
                this.Close();
                MessageBox.Show("Отметка успешно добавлена");
            }
            else
                MessageBox.Show("Ошибка внесения отметки");
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = studentList.SelectedItems[0] as Student;
            FillSubjectsBox(selectedStudent.Id);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
