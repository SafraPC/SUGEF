using SUGEF.Helpers;

namespace SUGEF.View.Student
{
    partial class StudentConfig
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
            this.SuspendLayout();
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Config";
            this.Text = "Configuração de Usuário";
            this.ResumeLayout(false);

        }
    }
}