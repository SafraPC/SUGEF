namespace SUGEF.View.Director
{
    partial class DirectorCreateSubject
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
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMateria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectProfessor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Criar Matéria";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.Green;
            this.createButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createButton.Location = new System.Drawing.Point(622, 311);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(123, 47);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Criar";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.matricularButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(455, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione o professor";
            // 
            // inputMateria
            // 
            this.inputMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputMateria.Location = new System.Drawing.Point(458, 228);
            this.inputMateria.Margin = new System.Windows.Forms.Padding(2);
            this.inputMateria.Name = "inputMateria";
            this.inputMateria.Size = new System.Drawing.Size(474, 26);
            this.inputMateria.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(455, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Insira o nome da matéria";
            // 
            // selectProfessor
            // 
            this.selectProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProfessor.FormattingEnabled = true;
            this.selectProfessor.Location = new System.Drawing.Point(458, 127);
            this.selectProfessor.Name = "selectProfessor";
            this.selectProfessor.Size = new System.Drawing.Size(474, 28);
            this.selectProfessor.TabIndex = 18;
            // 
            // DirectorCreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.selectProfessor);
            this.Controls.Add(this.inputMateria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label1);
            this.Name = "DirectorCreateSubject";
            this.Text = "DirectorIndex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputMateria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectProfessor;
    }
}