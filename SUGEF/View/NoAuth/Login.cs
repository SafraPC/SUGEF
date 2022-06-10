using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Services;
using SUGEF.View.Director;
using SUGEF.View.Professor;
using SUGEF.View.Student;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF
{
    public partial class LoginForm : Form
    {

        ConnectDB dataQuerys = new ConnectDB();
        public LoginForm()
        {
            InitializeComponent();
            new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            new SetButtonHover(this.loginButton, Color.Green);
            new SetPlaceholder(this.inputLogin, "Insira seu Login");
            new SetPlaceholder(this.inputPassword, "Insira sua Senha");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserController user = this.dataQuerys.Login(this.inputLogin.Text, this.inputPassword.Text);
                if (user.UserTipo == "Aluno")
                {
                    new ShowForm(this, new StudentIndex(user));
                    return;
                }
                if (user.UserTipo == "Professor")
                {
                    new ShowForm(this, new ProfessorIndex(user));
                    return;
                }
                if (user.UserTipo == "Diretor")
                {
                    new ShowForm(this, new DirectorIndex(user));
                    return;
                }
                MessageBox.Show("Credenciais Incorretas!", "Houve um erro ao fazer Login!!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception _ex)
            {
                MessageBox.Show("Houve um erro ao fazer Login!!!", "Houve um erro ao fazer Login!!!", MessageBoxButtons.OK);
            }
        }
    }
}
