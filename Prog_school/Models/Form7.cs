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
        public Form7()
        {
            InitializeComponent();
            fillBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var teacher =  new Teacher()
            //{
            //    F
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void fillBoxes ()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var subject = dbContext.Subjects.ToList();
                var cabinets = dbContext.Cabinets.ToList();
                cabinetListBox.ValueMember = "Id";
                cabinetListBox.DisplayMember = "Name";
                //subjectListBox.
                
            }
        }
    }
}
