﻿using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.View.Student;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            new SetButtonHover(this.loginButton, Color.Green);
            new SetPlaceholder(this.inputLogin, "Insira seu Login");
            new SetPlaceholder(this.inputPassword, "Insira sua Senha");
            new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            StudentController student = new StudentController(123123123,"Macelin","Marclin.jconectada@gmail.com","30");
            new ShowForm(this,new Index(student));
        }
    }
}
