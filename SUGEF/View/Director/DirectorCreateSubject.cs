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
    public partial class DirectorCreateSubject : Form
    {
        UserModel director = null;
        private MySqlConnection connect = new ConnectDB().Connection();
        private DirectorRequest diretorRequest = new DirectorRequest();
        public DirectorCreateSubject(UserModel director)
        {
            InitializeComponent();
            this.director = director;
            AutomatizeScreen formConfig = new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            formConfig.RenderSidebarDirector(this, director);
            setProfessors();
        }
    
        private void setProfessors()
        {
            try
            {
                connect.Open();
                List<string> professorSelect = new List<string>();
                MySqlCommand command = new MySqlCommand("SELECT Users.userId, Users.userName from Users WHERE userTipo = 'Professor';", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    professorSelect.Add(reader.GetString("userId") + " | " + reader.GetString("userNAME"));
                }
                for (int i = 0; i < professorSelect.Count; i++)
                {
                    this.selectProfessor.Items.Add(professorSelect[i]);
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
                string userId = "";
                if (this.selectProfessor.Text != "")
                {
                    userId = this.selectProfessor.Text.Split(' ')[0];
                }
               
                if (diretorRequest.CreateSubject(userId, this.inputMateria.Text))
                {
                    MessageBox.Show("Matéria criada com sucesso!");
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
