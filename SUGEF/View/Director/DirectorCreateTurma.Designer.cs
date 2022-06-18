namespace SUGEF.View.Director
{
    partial class DirectorCreateTurma
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
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.inputAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectPeriodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputTotalFaltas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastrar Turma";
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cadastrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarButton.ForeColor = System.Drawing.Color.Green;
            this.cadastrarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cadastrarButton.Location = new System.Drawing.Point(861, 586);
            this.cadastrarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(164, 58);
            this.cadastrarButton.TabIndex = 8;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // inputAno
            // 
            this.inputAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputAno.Location = new System.Drawing.Point(619, 416);
            this.inputAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputAno.Name = "inputAno";
            this.inputAno.Size = new System.Drawing.Size(631, 30);
            this.inputAno.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(615, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Insira o ano da turma";
            // 
            // selectMateria
            // 
            this.selectMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMateria.FormattingEnabled = true;
            this.selectMateria.Location = new System.Drawing.Point(619, 196);
            this.selectMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectMateria.Name = "selectMateria";
            this.selectMateria.Size = new System.Drawing.Size(631, 33);
            this.selectMateria.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(615, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Selecione a matéria";
            // 
            // selectPeriodo
            // 
            this.selectPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPeriodo.FormattingEnabled = true;
            this.selectPeriodo.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.selectPeriodo.Location = new System.Drawing.Point(619, 302);
            this.selectPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectPeriodo.Name = "selectPeriodo";
            this.selectPeriodo.Size = new System.Drawing.Size(631, 33);
            this.selectPeriodo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(615, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Selecione o período";
            // 
            // inputTotalFaltas
            // 
            this.inputTotalFaltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputTotalFaltas.Location = new System.Drawing.Point(619, 507);
            this.inputTotalFaltas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTotalFaltas.Name = "inputTotalFaltas";
            this.inputTotalFaltas.Size = new System.Drawing.Size(631, 30);
            this.inputTotalFaltas.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(615, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Insira a quantidade máxima de faltas";
            // 
            // DirectorCreateTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.inputTotalFaltas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DirectorCreateTurma";
            this.Text = "Cadastrar Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.TextBox inputAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputTotalFaltas;
        private System.Windows.Forms.Label label2;
    }
}