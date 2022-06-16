using SUGEF.Components;
using SUGEF.Controller.Student;
using SUGEF.View.Student;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class StudentSidebar : Panel
    {
        private Form form;
        private UserModel student;
        public StudentSidebar(Form form, UserModel student)
        {
            this.form = form;
            this.student = student;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, this.form.Height);
            base.OnPaint(e);
            //Create picture and data

            SidebarProps sidebarElements = new SidebarProps(this,this.form);
            sidebarElements.CreateHeader(student.UserName,student.UserCpf);
            //Create Panels
            sidebarElements.CreateSidebarElement("Turmas", "users", 150, new StudentTurmas(this.student));
            sidebarElements.CreateSidebarElement("Notas e Boletins", "file", 200, new StudentNotas(this.student));

            sidebarElements.CreateSidebarElement("Sair", "logout", this.form.Height-150, new LoginForm());
        }

    }
}
