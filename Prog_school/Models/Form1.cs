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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox4.Text;
            var password = textBox4.Text;
            using (AppDbContext dbContext = new AppDbContext()){
                //var teacherIsOnSystem = dbContext.Teachers.Any(t=> t.Login == login && password == t.Password);
                var teacherIsOnSystem = true;
                if (teacherIsOnSystem)
                {
                    var secondForm = new Form2();
                    secondForm.Show();//показывет следующую форму 
                    this.Hide();//скрывает предыдущую 
                }
            }
        }
    }
}
