﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Components
{

    public partial class ItemSidebar : Panel
    {
        public Image ICONIMAGE { get; set; }
        public string TITLE { get; set; }
        public bool SELECTED { get; set; }

        public EventHandler EVENT { get; set; }
        private void RemoveHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void AddHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.TabIndex = 0;
            this.Size = new Size(290, 44);
            this.Cursor = Cursors.Hand;
            this.Click += EVENT;
         
            //Add icon
            PictureBox pictureBox = new PictureBox();
            pictureBox.Enabled = false;
            pictureBox.Size = new Size(30, 30);
            pictureBox.Image = ICONIMAGE;
            pictureBox.MouseEnter += AddHover;
            pictureBox.MouseLeave += RemoveHover;
            pictureBox.Location = new Point(30, 12);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(pictureBox);

            //Add title
            Label title = new Label();
            title.Text = this.TITLE;
            title.Click += EVENT;
            title.ForeColor = Color.White;
            title.MouseEnter += AddHover;
            title.MouseLeave += RemoveHover;
            title.BackColor = Color.Transparent;
            title.Size = new Size(150, 34);
            title.Font = new Font("Cambria", 11, FontStyle.Regular);
            title.Location = new Point(80, 12);
            this.Controls.Add(title);

            base.OnPaint(e);
        }
    }
}
