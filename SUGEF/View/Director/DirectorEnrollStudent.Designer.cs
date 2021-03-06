namespace SUGEF.View.Director
{
    partial class DirectorEnrollStudent
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
            this.matricularButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAlunoFalta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectAluno = new System.Windows.Forms.ComboBox();
            this.selectTurma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricular Aluno";
            // 
            // matricularButton
            // 
            this.matricularButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.matricularButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matricularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matricularButton.ForeColor = System.Drawing.Color.Green;
            this.matricularButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.matricularButton.Location = new System.Drawing.Point(837, 470);
            this.matricularButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matricularButton.Name = "matricularButton";
            this.matricularButton.Size = new System.Drawing.Size(164, 58);
            this.matricularButton.TabIndex = 8;
            this.matricularButton.Text = "Matricular";
            this.matricularButton.UseVisualStyleBackColor = false;
            this.matricularButton.Click += new System.EventHandler(this.matricularButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(607, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione o aluno";
            // 
            // inputAlunoFalta
            // 
            this.inputAlunoFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputAlunoFalta.Location = new System.Drawing.Point(611, 368);
            this.inputAlunoFalta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputAlunoFalta.Name = "inputAlunoFalta";
            this.inputAlunoFalta.Size = new System.Drawing.Size(631, 30);
            this.inputAlunoFalta.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(607, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Insira o total de faltas da matricula";
            // 
            // selectAluno
            // 
            this.selectAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAluno.FormattingEnabled = true;
            this.selectAluno.Location = new System.Drawing.Point(611, 156);
            this.selectAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectAluno.Name = "selectAluno";
            this.selectAluno.Size = new System.Drawing.Size(631, 33);
            this.selectAluno.TabIndex = 18;
            // 
            // selectTurma
            // 
            this.selectTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTurma.FormattingEnabled = true;
            this.selectTurma.Location = new System.Drawing.Point(611, 260);
            this.selectTurma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectTurma.Name = "selectTurma";
            this.selectTurma.Size = new System.Drawing.Size(631, 33);
            this.selectTurma.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(607, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Selecione a turma";
            // 
            // DirectorEnrollStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.selectTurma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectAluno);
            this.Controls.Add(this.inputAlunoFalta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matricularButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DirectorEnrollStudent";
            this.Text = "Matricular Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button matricularButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAlunoFalta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectAluno;
        private System.Windows.Forms.ComboBox selectTurma;
        private System.Windows.Forms.Label label3;
    }
}