using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class Index : Form
    {
        UserModel student;
        public Index(UserModel student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            formConfig.RenderSidebarStudent(this, student);
        }
    }
}
