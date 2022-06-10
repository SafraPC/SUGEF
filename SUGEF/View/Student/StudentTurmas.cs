using SUGEF.Components.Cards;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class StudentTurmas : Form
    {
        UserController student;
        public StudentTurmas(UserController student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);


            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());
            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());
            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());
            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());

        }
    }
}
