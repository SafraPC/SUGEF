using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class Turmas : Form
    {
        public Turmas(StudentController student)
        {
            new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            InitializeComponent();
        }
    }
}
