using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class StudentSidebar : Panel
    {

        protected Panel CreateSidebarElement(string titleText)
        {
         

            Panel panel = new Panel();
            panel.Size = new Size(290, 44);
            panel.Cursor = Cursors.Hand;
            panel.BackColor = SystemColors.Highlight;

            void PutColor(object sender, EventArgs e) => panel.BackColor = Color.FromArgb(30, 60, 114);
            void RemoveColor(object sender, EventArgs e) => panel.BackColor = Color.Transparent;

            panel.MouseEnter += PutColor;
            panel.MouseLeave += RemoveColor;

            //Add icon
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(30, 30);
            pictureBox.MouseEnter += PutColor;
            pictureBox.MouseLeave += RemoveColor;
            pictureBox.Location = new Point(30, 12);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            panel.Controls.Add(pictureBox);

            //Add title
            Label title = new Label();
            title.Text = titleText;
            title.ForeColor = Color.White;
            title.MouseEnter += PutColor;
            title.MouseLeave += RemoveColor;
            title.Size = new Size(150, 34);
            title.Font = new Font("Cambria", 11, FontStyle.Regular);
            title.Location = new Point(80, 12);
            panel.Controls.Add(title);

            panel.Location = new Point(0, 10);

            return panel;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(70, 120, 222), Color.FromArgb(30, 60, 114), 90F);
            Graphics graph = e.Graphics;
            graph.FillRectangle(lgb, this.ClientRectangle);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 720);
            base.OnPaint(e);

            this.Controls.Add(CreateSidebarElement("teste"));

        }

    }
}
