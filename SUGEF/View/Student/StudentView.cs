using SUGEF.Controller.Student;
using SUGEF.Helpers;
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
    public partial class StudentView : Form
    {
        StudentController student;
        public StudentView(StudentController student)
        {
            this.student = student;
            InitializeComponent();
            new AutomatizeScreen(this, student.GetStudentName());
        }

        private void ConfigClick(object sender, EventArgs e)
        {
                new ShowForm(this, new ConfigUser(this.student));
        }
    }
}
