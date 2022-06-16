using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.View.Professor;
using System;
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
            title.Size = new Size(345, 30);
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
        
        public void CreateStudentPanel(FlowLayoutPanel flowPanel, string userId, string matriculaId, string turmaId, string notasId,
          string userName, string nota1, string nota2, string nota3, string nota4, string totalFaltas  )
        {
            Panel panel = new Panel();
            panel.Size = new Size(flowPanel.Width-50, 150);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.BackColor = Color.Azure;
            flowPanel.Controls.Add(panel);
        }
    }
}
