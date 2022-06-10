using SUGEF.Components;
using SUGEF.Controller.Student;
using SUGEF.View.Director;
using SUGEF.View.Student;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class DirectorSidebar : Panel
    {
        private Form form;
        private UserController director;
        public DirectorSidebar(Form form, UserController director)
        {
            this.form = form;
            this.director = director;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 720);
            base.OnPaint(e);
            //Create picture and data
            SidebarProps sidebarElements = new SidebarProps(this, this.form);

            sidebarElements.CreateHeader(this.director.UserName,this.director.UserCpf);
            //Create Panels
            sidebarElements.CreateSidebarElement("Criar Turma", "file", 150, new DirectorCreateTurma(this.director));
            sidebarElements.CreateSidebarElement("Criar Usuário", "file", 200, new DirectorCreateUser(this.director));
            sidebarElements.CreateSidebarElement("Pesquisar", "file", 250, new DirectorIndex(this.director));

            sidebarElements.CreateSidebarElement("Configurações","settings",600,new DirectorIndex(this.director));
            sidebarElements.CreateSidebarElement("Sair", "logout", 650, new LoginForm());
        }

    }
}
