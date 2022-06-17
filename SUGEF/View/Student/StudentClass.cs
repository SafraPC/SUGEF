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
    public partial class StudentTurmas : Form
    {
        private UserModel student;
        private MySqlConnection connect = new ConnectDB().Connection();
        private StudentCard studentCard = new StudentCard();
        public StudentTurmas(UserModel student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);
            SetTurmas();
        }

        private void SetTurmas()
        {
            try
            {
                connect.Open();
                List<string> studentTurmas = new List<string>();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Matricula INNER JOIN Turma ON " +
                " Turma.turmaId = Matricula.turmaId " +
                " INNER JOIN Materia ON Turma.materiaId = Materia.materiaId " +
                $" WHERE Matricula.userId = {student.UserId}; ", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    studentTurmas.Add(reader.GetString("turmaId") + "|" + reader.GetString("materiaNome") + "|" + reader.GetString("turmaPeriodo") + "|" +
                        reader.GetString("turmaAno"));
                }
                studentTurmas.ForEach(item =>
                {
                    Debug.WriteLine(item);
                    this.flowPanel.Controls.Add(studentCard.CreateTurmasPanel(item, this, student));
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
