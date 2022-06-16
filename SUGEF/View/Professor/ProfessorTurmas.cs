using MySql.Data.MySqlClient;
using SUGEF.Components.Cards;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class ProfessorTurmas : Form
    {
        private UserModel professor;
        private MySqlConnection connect = new ConnectDB().Connection();
        private ProfessorsCard card = new ProfessorsCard();

        public ProfessorTurmas(UserModel professor)
        {
            InitializeComponent();
            this.professor = professor;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarProfessor(this, professor);
            SetCards();
        }

        private void SetCards()
        {
            try
            {
                connect.Open();
                List<string> professorTurmas = new List<string>();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM Materia INNER JOIN Turma on Turma.materiaId = Materia.materiaId WHERE userId = {professor.UserId}; ", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    professorTurmas.Add(reader.GetString("turmaId") + "|" + reader.GetString("materiaNome") + "|" + reader.GetString("turmaPeriodo") + "|" +
                        reader.GetString("turmaAno"));
                }
                professorTurmas.ForEach(item =>
                {
                    Debug.WriteLine(item);
                    this.flowPanel.Controls.Add(card.CreateTurmasPanel(item));
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                connect.Close();
            }


        }
    }
}
