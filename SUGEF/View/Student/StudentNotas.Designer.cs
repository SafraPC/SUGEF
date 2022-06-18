namespace SUGEF.View.Student
{
    partial class StudentNotas
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
            this.table = new System.Windows.Forms.DataGridView();
            this.disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplina,
            this.faltas,
            this.aulas,
            this.freq,
            this.n1,
            this.n2,
            this.n3,
            this.n4,
            this.media,
            this.situacao});
            this.table.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table.Location = new System.Drawing.Point(361, 60);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.Size = new System.Drawing.Size(1066, 728);
            this.table.TabIndex = 7;
            // 
            // disciplina
            // 
            this.disciplina.HeaderText = "Disciplina";
            this.disciplina.MinimumWidth = 6;
            this.disciplina.Name = "disciplina";
            this.disciplina.ReadOnly = true;
            this.disciplina.Width = 125;
            // 
            // faltas
            // 
            this.faltas.HeaderText = "T. Faltas";
            this.faltas.MinimumWidth = 6;
            this.faltas.Name = "faltas";
            this.faltas.ReadOnly = true;
            this.faltas.Width = 125;
            // 
            // aulas
            // 
            this.aulas.HeaderText = "T. Aulas";
            this.aulas.MinimumWidth = 6;
            this.aulas.Name = "aulas";
            this.aulas.ReadOnly = true;
            this.aulas.Width = 125;
            // 
            // freq
            // 
            this.freq.HeaderText = "Freq.";
            this.freq.MinimumWidth = 6;
            this.freq.Name = "freq";
            this.freq.ReadOnly = true;
            this.freq.Width = 125;
            // 
            // n1
            // 
            this.n1.HeaderText = "N1";
            this.n1.MinimumWidth = 6;
            this.n1.Name = "n1";
            this.n1.ReadOnly = true;
            this.n1.Width = 125;
            // 
            // n2
            // 
            this.n2.HeaderText = "N2";
            this.n2.MinimumWidth = 6;
            this.n2.Name = "n2";
            this.n2.ReadOnly = true;
            this.n2.Width = 125;
            // 
            // n3
            // 
            this.n3.HeaderText = "N3";
            this.n3.MinimumWidth = 6;
            this.n3.Name = "n3";
            this.n3.ReadOnly = true;
            this.n3.Width = 125;
            // 
            // n4
            // 
            this.n4.HeaderText = "N4";
            this.n4.MinimumWidth = 6;
            this.n4.Name = "n4";
            this.n4.ReadOnly = true;
            this.n4.Width = 125;
            // 
            // media
            // 
            this.media.HeaderText = "Média";
            this.media.MinimumWidth = 6;
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Width = 125;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situação";
            this.situacao.MinimumWidth = 6;
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 125;
            // 
            // pdfButton
            // 
            this.pdfButton.BackColor = System.Drawing.Color.White;
            this.pdfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdfButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pdfButton.Location = new System.Drawing.Point(1294, 12);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(133, 41);
            this.pdfButton.TabIndex = 8;
            this.pdfButton.Text = "PDF";
            this.pdfButton.UseVisualStyleBackColor = false;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // StudentNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 886);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentNotas";
            this.Text = "Turmas e Boletins";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2;
        private System.Windows.Forms.DataGridViewTextBoxColumn n3;
        private System.Windows.Forms.DataGridViewTextBoxColumn n4;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.Button pdfButton;
    }
}