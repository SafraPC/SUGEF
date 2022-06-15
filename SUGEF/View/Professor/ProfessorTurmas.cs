using SUGEF.Components.Cards;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class ProfessorTurmas : Form
    {
        UserModel professor;
        public ProfessorTurmas(UserModel professor)
        {
            InitializeComponent();
            this.professor = professor;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarProfessor(this, professor);


            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());
            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());
            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());
            this.flowPanel.Controls.Add(new StudentCard().CreateTurmasPanel());

        }
    }
}
