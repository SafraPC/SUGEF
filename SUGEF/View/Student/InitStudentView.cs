using SUGEF.Controller.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class InitStudentView : Form
    {

       StudentController student;
        public InitStudentView(StudentController student)
        {
            InitializeComponent();
            this.student = student;
            this.Text += " " + student.GetStudentName() + "!";
        }

        private void InitStudentView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
