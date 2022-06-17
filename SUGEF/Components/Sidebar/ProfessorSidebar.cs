using SUGEF.Components;
using SUGEF.Controller.Student;
using SUGEF.View.Professor;
using SUGEF.View.Student;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class ProfessorSidebar : Panel
    {
        private Form form;
        private UserModel professor;
        public ProfessorSidebar(Form form, UserModel professor)
        {
            this.form = form;
            this.professor = professor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, this.form.Height);
            base.OnPaint(e);
            //Create picture and data
            SidebarProps sidebarElements = new SidebarProps(this, this.form);

            sidebarElements.CreateHeader(this.professor.UserName,this.professor.UserCpf);
            //Create Panels
            sidebarElements.CreateSidebarElement("Turmas", "users", 150, new ProfessorTurmas(this.professor));

            sidebarElements.CreateSidebarElement("Sair", "logout", this.form.Height - 120, new LoginForm());
        }

    }
}
