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
    public partial class StudentClass : Form
    {
        private UserModel student;
        private MySqlConnection connect = new ConnectDB().Connection();
        private StudentCard studentCard = new StudentCard();
        string turma;
        public StudentClass(UserModel student, string turmaId)
        {
            this.turma = turmaId;
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
                MySqlCommand command = new MySqlCommand("SELECT Users.userName FROM Turma INNER JOIN Matricula " +
                    "ON Matricula.turmaId = Turma.turmaId INNER JOIN Users ON Users.userId = Matricula.userId " +
                    $"WHERE Turma.turmaId = {this.turma};", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.flowPanel.Controls.Add(studentCard.CreateStudentCard(reader.GetString("userName")));
                }
               
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
