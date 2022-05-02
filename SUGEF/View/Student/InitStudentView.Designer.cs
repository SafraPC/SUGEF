namespace SUGEF.View.Student
{
    partial class InitStudentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradientSidebar1 = new SUGEF.Utils.GradientSidebar();
            this.SuspendLayout();
            // 
            // gradientSidebar1
            // 
            this.gradientSidebar1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(222)))));
            this.gradientSidebar1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.gradientSidebar1.Location = new System.Drawing.Point(0, 0);
            this.gradientSidebar1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientSidebar1.Name = "gradientSidebar1";
            this.gradientSidebar1.Size = new System.Drawing.Size(290, 856);
            this.gradientSidebar1.TabIndex = 0;
            // 
            // InitStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 864);
            this.Controls.Add(this.gradientSidebar1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "InitStudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seja bem-vindo ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitStudentView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.GradientSidebar gradientSidebar1;
    }
}