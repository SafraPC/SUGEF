using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Model.Director;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SUGEF.View.Director
{
    public partial class DirectorCreateUser : Form
    {
        UserModel director = null;
        DirectorRequest directorModel = new DirectorRequest();
        public DirectorCreateUser(UserModel director)
        {
            InitializeComponent();
            this.director = director;
            AutomatizeScreen formConfig = new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            formConfig.RenderSidebarDirector(this, director);
        }

        //handle submit
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (directorModel.CreateUser(this.inputNome.Text, this.inputUserTipo.Text, this.inputLogin.Text,
                   this.inputPassword.Text, this.inputDate.Text, this.inputCpf.Text))
                {
                    MessageBox.Show($"{this.inputUserTipo.Text} cadastrado com sucesso!","Sucesso!");
                    this.inputNome.Text = "";
                    this.inputLogin.Text = "";
                    this.inputPassword.Text = "";
                    this.inputDate.Text = "";
                    this.inputCpf.Text = "";
                }
                else
                {
                    MessageBox.Show("Houve um erro ao cadastrar o usuário, verifique os dados e tente novamente!", "Ocorreu um erro durante a execução!", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Algo deu errado!","Ocorreu um erro durante a execução.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
