namespace SUGEF.View.Student
{
    partial class ProfessorTurmas
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(296, 12);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(772, 696);
            this.flowPanel.TabIndex = 1;
            // 
            // ProfessorTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.flowPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfessorTurmas";
            this.Text = "Turmas";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}