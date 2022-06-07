namespace SUGEF.View.Student
{
    partial class Index
    {
     
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.studentSidebar1 = new Utils.StudentSidebar(this);
            // 
            // studentSidebar1
            // 
            this.studentSidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.studentSidebar1.Location = new System.Drawing.Point(0, 0);
            this.studentSidebar1.Name = "studentSidebar1";
            this.studentSidebar1.Size = new System.Drawing.Size(290, 720);
            this.studentSidebar1.TabIndex = 0;
            this.Controls.Add(this.studentSidebar1);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seja bem-vindo ";
            this.ResumeLayout(false);

        }
        private Utils.StudentSidebar studentSidebar1;
    }
}