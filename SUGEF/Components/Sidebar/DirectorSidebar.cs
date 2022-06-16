using SUGEF.Components;
using SUGEF.Controller.Student;
using SUGEF.View.Director;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class DirectorSidebar : Panel
    {
        private Form form;
        private UserModel director;
        public DirectorSidebar(Form form, UserModel director)
        {
            this.form = form;
            this.director = director;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, this.form.Height);
            base.OnPaint(e);
            //Create picture and data
            SidebarProps sidebarElements = new SidebarProps(this, this.form);

            sidebarElements.CreateHeader(this.director.UserName,this.director.UserCpf);
            //Create Panels
            sidebarElements.CreateSidebarElement("Criar Turma", "file", 150, new DirectorCreateTurma(this.director));
            sidebarElements.CreateSidebarElement("Criar Usuário", "file", 200, new DirectorCreateUser(this.director));
            sidebarElements.CreateSidebarElement("Criar Matéria", "file", 250, new DirectorCreateSubject(this.director));
            sidebarElements.CreateSidebarElement("Matricular Aluno", "file", 300, new DirectorEnrollStudent(this.director));
            sidebarElements.CreateSidebarElement("Pesquisar", "file", 350, new DirectorIndex(this.director));


            sidebarElements.CreateSidebarElement("Configurações","settings", this.form.Height-100, new DirectorIndex(this.director));
            sidebarElements.CreateSidebarElement("Sair", "logout", this.form.Height-50, new LoginForm());
        }

    }
}
