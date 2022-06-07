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

        Form student;
        public StudentSidebar(Form student)
        {
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
            void ChangeForm(object sender, EventArgs e) => new ShowForm(this.student, form);
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

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = defaultSidebarColor;
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 720);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            base.OnPaint(e);

            this.Controls.Add(CreateSidebarElement("Turmas", "users", 150, new Turmas()));
            this.Controls.Add(CreateSidebarElement("Notas e Boletins", "file", 200, new NotasBoletins()));

            this.Controls.Add(CreateSidebarElement("Configurações","settings",550,new Config()));
            this.Controls.Add(CreateSidebarElement("Sair", "logout", 600, new LoginForm()));
        }

    }
}
