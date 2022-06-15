using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Model.Director;
using SUGEF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUGEF.View.Director
{
    public partial class DirectorCreateTurma : Form
    {
        UserModel director = null;
        private MySqlConnection connect = new ConnectDB().Connection();
        private DirectorRequest diretorRequest = new DirectorRequest();
        public DirectorCreateTurma(UserModel director)
        {
            InitializeComponent();
            this.director = director;
            AutomatizeScreen formConfig = new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            formConfig.RenderSidebarDirector(this, director);
            setMateriaSelect();
        }

        private void setMateriaSelect()
        {
            try
            {
                connect.Open();
                List<string> materiaSelect = new List<string>();
                MySqlCommand command = new MySqlCommand("SELECT Materia.materiaId, Users.userName, Materia.materiaNome FROM Users INNER JOIN" +
                " Materia WHERE Users.userId = Materia.userId;", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    materiaSelect.Add(reader.GetString("materiaId") + " " + reader.GetString("materiaNome") +
                       " | " + reader.GetString("userName"));
                }
                for (int i = 0; i < materiaSelect.Count; i++)
                {
                    this.selectMateria.Items.Add(materiaSelect[i]);
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

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {

                string materia = "";
                if (this.selectMateria.Text != "")
                {
                    materia = this.selectMateria.Text.Split(' ')[0];
                }
                if (diretorRequest.CreateTurma(materia, this.selectPeriodo.Text, this.inputAno.Text,this.inputTotalFaltas.Text))
                {
                    MessageBox.Show("Turma cadastrada com sucesso!", "Sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar turma, valide os dados!", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro!", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }

        }
    }
}
