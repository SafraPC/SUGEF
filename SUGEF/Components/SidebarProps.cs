using SUGEF.Helpers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SUGEF.Components
{
    internal class SidebarProps
    {
        private Color defaultSidebarColor = Color.FromArgb(30, 60, 114);
        private Color placeholderColor = Color.FromArgb(43, 81, 147);

        private Form form = null;
        private Panel panel = null; 
        public SidebarProps(Panel panel,Form form)
        {
            this.panel = panel;
            this.form = form;
        }

        public void CreateHeader(string name, string id)
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
            this.panel.Controls.Add(userImg);

            //Add User Name
            Label username = new Label();
            username.Location = new Point(130, 40);
            username.Size = new Size(150, 20);
            username.Text = name;
            username.Font = new Font("Cambria", 11, FontStyle.Regular);
            username.ForeColor = Color.White;
            this.panel.Controls.Add(username);

            //Add User Id
            Label usernameId = new Label();
            usernameId.Location = new Point(130, 65);
            usernameId.Size = new Size(150, 20);
            usernameId.Text = id;
            usernameId.Font = new Font("Cambria", 11, FontStyle.Regular);
            usernameId.ForeColor = Color.White;
            this.panel.Controls.Add(usernameId);
        }


        public void CreateSidebarElement(string titleText, string icon, int location, Form form)
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
            }
            catch (Exception ex)
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

            this.panel.Controls.Add(panel);
        }
    }
}
