using MySql.Data.MySqlClient;
using SUGEF.Components.Cards;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SUGEF.View.Professor
{
    public partial class ProfessorClass : Form
    {
        ProfessorsCard professorCard = new ProfessorsCard();
        private MySqlConnection connect = new ConnectDB().Connection();
        private string turma = "";
        public ProfessorClass(UserModel professor,string turma)
        {
            this.turma = turma;
            InitializeComponent();
            AutomatizeScreen formConfig = new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            formConfig.RenderSidebarProfessor(this, professor);
            SetStudentsCards();
        }

        private void SetStudentsCards()
        {
            try
            {
                this.connect.Open();
                UserModel professorSelect = new UserModel();
                MySqlCommand command = new MySqlCommand("SELECT Users.userId, Matricula.matriculaId, turmaId, Notas.notasId, Users.userName, Notas.nota1, "+
                "Notas.nota2, Notas.nota3, Notas.nota4, Matricula.totalFaltas FROM Matricula INNER JOIN Users ON "+
                "Users.userId = Matricula.userId "+
                "INNER JOIN Notas ON Notas.matriculaId = Matricula.matriculaId "+
                $"WHERE turmaId = {this.turma}; ", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.professorCard.CreateStudentPanel(this.flowPanel, reader.GetString("matriculaId"), 
                        reader.GetString("notasId"), reader.GetString("userName"), reader.GetString("nota1"), reader.GetString("nota2"), reader.GetString("nota3"),
                        reader.GetString("nota4"), reader.GetString("totalFaltas"),connect);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                this.connect.Close();
            }
        }
    }
}
