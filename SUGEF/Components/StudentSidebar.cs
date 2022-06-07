using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.View.Student;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class StudentSidebar : Panel
    {

        private Color defaultSidebarColor = Color.FromArgb(30, 60, 114);
        private Color placeholderColor = Color.FromArgb(43, 81, 147);

        private Form form;
        private StudentController student;
        public StudentSidebar(Form form, StudentController student)
        {
            this.form = form;
            this.student = student;
        }

        protected Panel CreateSidebarElement(string titleText, string icon, int location,Form form)
        {
         
            Panel panel = new Panel();
            panel.Size = new Size(290, 50);
            panel.Cursor = Cursors.Hand;
            panel.BackColor = defaultSidebarColor;
            panel.Location = new Point(0, location);

            void PutColor(object sender, EventArgs e) => panel.BackColor = placeholderColor;
            void RemoveColor(object sender, EventArgs e) => panel.BackColor = defaultSidebarColor;
            void ChangeForm(object sender, EventArgs e) => new ShowForm(this.form, form);
            panel.Click += ChangeForm;
            panel.MouseEnter += PutColor;
            panel.MouseLeave += RemoveColor;

            //Add icon
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(30, 30);
            pictureBox.MouseEnter += PutColor;
            pictureBox.Click += ChangeForm;
            pictureBox.MouseLeave += RemoveColor;
            pictureBox.Location = new Point(30, 12);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            try
            {
                pictureBox.Load(@"" + Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Assets\\" + icon + ".png");
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            panel.Controls.Add(pictureBox);

            //Add title
            Label title = new Label();
            title.Text = titleText;
            title.ForeColor = Color.White;
            title.MouseEnter += PutColor;
            title.Click += ChangeForm;
            title.MouseLeave += RemoveColor;
            title.Size = new Size(150, 34);
            title.Font = new Font("Cambria", 11, FontStyle.Regular);
            title.Location = new Point(80, 12);

            panel.Controls.Add(title);
            return panel;
        }


        private void RenderHeader()
        {
            //Add user Image
            PictureBox userImg = new PictureBox();
            userImg.Location = new Point(10, 10);
            try
            {
            userImg.Load(@"" + Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Assets\\" + "userImage.png");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            userImg.Size = new Size(110, 100);
            userImg.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(userImg);

            //Add User Name
            Label username = new Label();
            username.Location = new Point(130, 40);
            username.Size = new Size(150, 20);
            username.Text = this.student.GetStudentName();
            username.Font = new Font("Cambria", 11, FontStyle.Regular);
            username.ForeColor = Color.White;
            this.Controls.Add(username);

            //Add User Id
            Label usernameId = new Label();
            usernameId.Location = new Point(130, 65);
            usernameId.Size = new Size(150, 20);
            usernameId.Text = this.student.GetStudentID().ToString();
            usernameId.Font = new Font("Cambria", 11, FontStyle.Regular);
            usernameId.ForeColor = Color.White;
            this.Controls.Add(usernameId);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = defaultSidebarColor;
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 720);
            base.OnPaint(e);

            //Create picture and data

            RenderHeader();

            //Create Panels
            this.Controls.Add(CreateSidebarElement("Turmas", "users", 150, new Turmas(this.student)));
            this.Controls.Add(CreateSidebarElement("Notas e Boletins", "file", 200, new NotasBoletins(this.student)));

            this.Controls.Add(CreateSidebarElement("Configurações","settings",550,new Config(this.student)));
            this.Controls.Add(CreateSidebarElement("Sair", "logout", 600, new LoginForm()));
        }

    }
}
