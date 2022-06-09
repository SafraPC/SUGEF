using SUGEF.Components;
using SUGEF.Controller.Student;
using SUGEF.View.Student;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class ProfessorSidebar : Panel
    {
        private Form form;
        private StudentController professor;
        public ProfessorSidebar(Form form, StudentController professor)
        {
            this.form = form;
            this.professor = professor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 720);
            base.OnPaint(e);
            //Create picture and data
            SidebarProps sidebarElements = new SidebarProps(this, this.form);

            sidebarElements.CreateHeader(this.professor.GetStudentName(),this.professor.GetStudentID().ToString());
            //Create Panels
            sidebarElements.CreateSidebarElement("Turmas", "users", 150, new Turmas(this.professor));
            sidebarElements.CreateSidebarElement("Notas e Boletins", "file", 200, new NotasBoletins(this.professor));

            sidebarElements.CreateSidebarElement("Configurações","settings",600,new Config(this.professor));
            sidebarElements.CreateSidebarElement("Sair", "logout", 650, new LoginForm());
        }

    }
}
