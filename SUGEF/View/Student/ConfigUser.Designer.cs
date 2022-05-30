namespace SUGEF.View.Student
{
    partial class ConfigUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUser));
            this.gradientSidebar1 = new SUGEF.Utils.GradientSidebar();
            this.itemSidebar1 = new SUGEF.Components.ItemSidebar();
            this.gradientSidebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientSidebar1
            // 
            this.gradientSidebar1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(222)))));
            this.gradientSidebar1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.gradientSidebar1.Controls.Add(this.itemSidebar1);
            this.gradientSidebar1.Location = new System.Drawing.Point(0, 0);
            this.gradientSidebar1.Name = "gradientSidebar1";
            this.gradientSidebar1.Size = new System.Drawing.Size(290, 720);
            this.gradientSidebar1.TabIndex = 0;
            // 
            // itemSidebar1
            // 
            this.itemSidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.itemSidebar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemSidebar1.ICONIMAGE = ((System.Drawing.Image)(resources.GetObject("itemSidebar1.ICONIMAGE")));
            this.itemSidebar1.Location = new System.Drawing.Point(0, 630);
            this.itemSidebar1.Name = "itemSidebar1";
            this.itemSidebar1.SELECTED = true;
            this.itemSidebar1.Size = new System.Drawing.Size(290, 44);
            this.itemSidebar1.TabIndex = 0;
            this.itemSidebar1.TITLE = "Configurações";
            // 
            // ConfigUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 714);
            this.Controls.Add(this.gradientSidebar1);
            this.Name = "ConfigUser";
            this.Text = "ConfigUser";
            this.gradientSidebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.GradientSidebar gradientSidebar1;
        private Components.ItemSidebar itemSidebar1;
    }
}