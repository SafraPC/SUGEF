using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class Index : Form
    {
        private StudentController student;
        public Index(StudentController student)
        {
            this.student = student;
            InitializeComponent();
            new AutomatizeScreen(this, student.GetStudentName());
        }

        private void ConfigClick(object sender, EventArgs e)
        {
                new ShowForm(this, new NotasBoletins(this.student));
        }
    }
}
