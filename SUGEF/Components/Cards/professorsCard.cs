using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.View.Professor;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Components.Cards
{
    public class ProfessorsCard
    {
        
        public Panel CreateTurmasPanel(string cardData, Form form, UserModel user)
        {
            string[] card = cardData.Split('|');
            string materiaNome = card[1];
            string turma = card[0];
            string descriptionText = "Turma: " +turma + "\nPeríodo" + card[3];

            Panel panel = new Panel();
            panel.Size = new Size(345, 290);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label title = new Label();
            title.Font = new Font("Cambria", 18, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Location = new Point(0, 20);
            title.Size = new Size(345, 50);
            title.Text = materiaNome;
            title.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(title);

            Label description = new Label();
            description.Font = new Font("Cambria", 13, FontStyle.Regular);
            description.ForeColor = Color.Black;
            description.Location = new Point(0, 115);
            description.TextAlign = ContentAlignment.MiddleCenter;
            description.Size = new Size(345, 60);
            description.Text = descriptionText;
            panel.Controls.Add(description);


            Button button = new Button();
            button.Font = new Font("Cambria", 13, FontStyle.Regular);
            button.Location = new Point(100, 220);
            button.FlatStyle = FlatStyle.Popup;
            button.Cursor = Cursors.Hand;
            button.Click += (object sender, EventArgs e) =>
            {
                new ShowForm(form, new ProfessorClass(user, turma));
            };
            button.Text = "Acessar";
            button.Size = new Size(145, 40);
            button.BackColor = Color.Azure;
            panel.Controls.Add(button);

            return panel;
        }

        private TextBox CreateInputStudentField(int x,string title,string notasText, Panel panel)
        {
            TextBox studentNota = new TextBox();
            studentNota.Size = new Size(50, 40);
            studentNota.Font = new Font("Cambria", 14, FontStyle.Regular);
            studentNota.Location = new Point(x, 70);
            studentNota.Text = notasText;
            panel.Controls.Add(studentNota);


            Label studentNotaLabel = new Label();
            studentNotaLabel.Location = new Point(x-60, 75);
            studentNotaLabel.Size = new Size(60, 40);
            studentNotaLabel.Font = new Font("Cambria", 12, FontStyle.Regular);
            studentNotaLabel.ForeColor = Color.Black;
            studentNotaLabel.Text = title;
            panel.Controls.Add(studentNotaLabel);

            return studentNota;
        }
        
        public void CreateStudentPanel(FlowLayoutPanel flowPanel,  string matriculaId, string notasId,
          string userName, string nota1, string nota2, string nota3, string nota4, string totalFaltas, MySqlConnection connect)
        {
            Panel panel = new Panel();
            panel.Size = new Size(flowPanel.Width-50, 200);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;

            Label studentName = new Label();
            studentName.Location = new Point(20, 10);
            studentName.Size = new Size(150,30);
            studentName.Font = new Font("Cambria", 16, FontStyle.Regular);
            studentName.ForeColor = Color.Black;
            studentName.Text = userName;
            panel.Controls.Add(studentName);

            TextBox nota1Input = CreateInputStudentField(80,"Nota 1:", nota1,panel);
            TextBox nota2Input = CreateInputStudentField(200, "Nota 2:", nota2, panel);
            TextBox nota3Input = CreateInputStudentField(320, "Nota 3:", nota3, panel);
            TextBox nota4Input = CreateInputStudentField(440, "Nota 4:", nota4, panel);
            TextBox faltasInput = CreateInputStudentField(560, "Faltas:", totalFaltas, panel);

            Button handleSubmit = new Button();
            handleSubmit.Location = new Point((flowPanel.Width / 2) - 80,130);
            handleSubmit.Size = new Size(120, 50);
            handleSubmit.Text = "Alterar";
            handleSubmit.BackColor = Color.Azure;
            handleSubmit.FlatStyle = FlatStyle.Popup;
            handleSubmit.Cursor = Cursors.Hand;
            handleSubmit.Font = new Font("Cambria", 13, FontStyle.Regular);
            handleSubmit.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    connect.Open();
                    UserModel professorSelect = new UserModel();
                    MySqlCommand command = new MySqlCommand("UPDATE Notas SET "+
                        $"nota1={nota1Input.Text}, nota2={nota2Input.Text}, nota3={nota3Input.Text}, nota4={nota4Input.Text} WHERE notasId={notasId}", connect);
                    MySqlDataReader reader = command.ExecuteReader();
                    connect.Close();

                    connect.Open();
                    MySqlCommand command2 = new MySqlCommand("UPDATE Matricula SET " +
                        $"totalFaltas={faltasInput.Text} WHERE matriculaId={matriculaId}", connect);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    connect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Infelizmente houve um erro!","Houve um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            };
             panel.Controls.Add(handleSubmit);

            flowPanel.Controls.Add(panel);
        }
    }
}
