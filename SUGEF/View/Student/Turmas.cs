using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class Turmas : Form
    {
        StudentController student;
        public Turmas(StudentController student)
        {
            this.student = student; 
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);
            InitializeComponent();
        }
    }
}
