namespace SUGEF.View.Student
{
    partial class Turmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turmas));
            this.gradientSidebar1 = new SUGEF.Utils.GradientSidebar();
            this.itemNotas = new SUGEF.Components.ItemSidebar();
            this.itemTurmas = new SUGEF.Components.ItemSidebar();
            this.itemSair = new SUGEF.Components.ItemSidebar();
            this.itemConfig = new SUGEF.Components.ItemSidebar();
            this.idLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.gradientSidebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientSidebar1
            // 
            this.gradientSidebar1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(222)))));
            this.gradientSidebar1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.gradientSidebar1.Controls.Add(this.itemNotas);
            this.gradientSidebar1.Controls.Add(this.itemTurmas);
            this.gradientSidebar1.Controls.Add(this.itemSair);
            this.gradientSidebar1.Controls.Add(this.itemConfig);
            this.gradientSidebar1.Controls.Add(this.idLabel);
            this.gradientSidebar1.Controls.Add(this.firstName);
            this.gradientSidebar1.Controls.Add(this.userPicture);
            this.gradientSidebar1.Location = new System.Drawing.Point(0, 0);
            this.gradientSidebar1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientSidebar1.Name = "gradientSidebar1";
            this.gradientSidebar1.Size = new System.Drawing.Size(290, 720);
            this.gradientSidebar1.TabIndex = 1;
            // 
            // itemNotas
            // 
            this.itemNotas.BackColor = System.Drawing.Color.Transparent;
            this.itemNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemNotas.EVENT = null;
            this.itemNotas.ICONIMAGE = ((System.Drawing.Image)(resources.GetObject("itemNotas.ICONIMAGE")));
            this.itemNotas.Location = new System.Drawing.Point(0, 163);
            this.itemNotas.Name = "itemNotas";
            this.itemNotas.SELECTED = false;
            this.itemNotas.Size = new System.Drawing.Size(290, 44);
            this.itemNotas.TabIndex = 0;
            this.itemNotas.TITLE = "Notas e Boletins";
            // 
            // itemTurmas
            // 
            this.itemTurmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.itemTurmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemTurmas.EVENT = null;
            this.itemTurmas.ICONIMAGE = ((System.Drawing.Image)(resources.GetObject("itemTurmas.ICONIMAGE")));
            this.itemTurmas.Location = new System.Drawing.Point(0, 113);
            this.itemTurmas.Name = "itemTurmas";
            this.itemTurmas.SELECTED = true;
            this.itemTurmas.Size = new System.Drawing.Size(290, 44);
            this.itemTurmas.TabIndex = 0;
            this.itemTurmas.TITLE = "Turmas";
            // 
            // itemSair
            // 
            this.itemSair.BackColor = System.Drawing.Color.Transparent;
            this.itemSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemSair.EVENT = null;
            this.itemSair.ICONIMAGE = ((System.Drawing.Image)(resources.GetObject("itemSair.ICONIMAGE")));
            this.itemSair.Location = new System.Drawing.Point(0, 604);
            this.itemSair.Name = "itemSair";
            this.itemSair.SELECTED = false;
            this.itemSair.Size = new System.Drawing.Size(290, 44);
            this.itemSair.TabIndex = 0;
            this.itemSair.TITLE = "Sair";
            // 
            // itemConfig
            // 
            this.itemConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.itemConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemConfig.EVENT = null;
            this.itemConfig.ICONIMAGE = ((System.Drawing.Image)(resources.GetObject("itemConfig.ICONIMAGE")));
            this.itemConfig.Location = new System.Drawing.Point(2, 555);
            this.itemConfig.Margin = new System.Windows.Forms.Padding(2);
            this.itemConfig.Name = "itemConfig";
            this.itemConfig.SELECTED = false;
            this.itemConfig.Size = new System.Drawing.Size(290, 44);
            this.itemConfig.TabIndex = 0;
            this.itemConfig.TITLE = "Configurações";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idLabel.Location = new System.Drawing.Point(98, 61);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "id";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.White;
            this.firstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.firstName.Location = new System.Drawing.Point(98, 31);
            this.firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(101, 17);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "PrimeiroNome";
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPicture.BackgroundImage")));
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(7, 17);
            this.userPicture.Margin = new System.Windows.Forms.Padding(0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(80, 80);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.gradientSidebar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Turmas";
            this.Text = "ConfigUser";
            this.gradientSidebar1.ResumeLayout(false);
            this.gradientSidebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.GradientSidebar gradientSidebar1;
        private Components.ItemSidebar itemNotas;
        private Components.ItemSidebar itemTurmas;
        private Components.ItemSidebar itemSair;
        private Components.ItemSidebar itemConfig;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.PictureBox userPicture;
    }
}