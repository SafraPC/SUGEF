using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Model.Director;
using SUGEF.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SUGEF.View.Director
{
    public partial class DirectorEnrollStudent : Form
    {
        UserModel director = null;
        private MySqlConnection connect = new ConnectDB().Connection();
        private DirectorRequest diretorRequest = new DirectorRequest();
        public DirectorEnrollStudent(UserModel director)
        {
            InitializeComponent();
            this.director = director;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarDirector(this, director);
            setMateriaSelect();
            setTurmas();
        }
        private void setMateriaSelect()
        {
            try
            {
                connect.Open();
                List<string> userSelect = new List<string>();
                MySqlCommand command = new MySqlCommand("SELECT Users.userId, Users.userName from Users WHERE userTipo = 'Aluno';", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userSelect.Add(reader.GetString("userId") + " | " + reader.GetString("userName"));
                }
                for (int i = 0; i < userSelect.Count; i++)
                {
                    this.selectAluno.Items.Add(userSelect[i]);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void setTurmas()
        {
            try
            {

                connect.Open();
                List<string> turmaSelect = new List<string>();
                MySqlCommand command = new MySqlCommand("SELECT Turma.turmaPeriodo, Turma.turmaAno, Turma.turmaId, Users.userName, Materia.materiaNome FROM Turma INNER JOIN Materia on Materia.materiaId = Turma.materiaId INNER JOIN Users " +
                "ON Users.userId = Materia.userId", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    turmaSelect.Add(reader.GetString("turmaId") + " | " + reader.GetString("userName") +
                        " | " + reader.GetString("materiaNome") + " | " + reader.GetString("turmaAno"));
                }
                for (int i = 0; i < turmaSelect.Count; i++)
                {
                    this.selectTurma.Items.Add(turmaSelect[i]);
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

        private void matricularButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = "", turmaId = "";
                if (this.selectAluno.Text != "")
                {
                    userId = this.selectAluno.Text.Split(' ')[0];
                }
                if (this.selectTurma.Text != "")
                {
                    turmaId = this.selectTurma.Text.Split(' ')[0];
                }
                if (diretorRequest.EnrollUser(userId, turmaId, this.inputAlunoFalta.Text))
                {
                    MessageBox.Show("Aluno matriculado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Houve um erro, verifique os campos!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
