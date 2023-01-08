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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var teachersForm = new Form4();
            teachersForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var studentsForm = new Form3();
            studentsForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var  form =  new Form10();
            form.ShowDialog();
        }
    }
}
