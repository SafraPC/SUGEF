using SUGEF.Controller.Student;
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
            new SetPlaceholder(this.inputLogin,"Insira seu Login");
            new SetPlaceholder(this.inputPassword, "Insira sua Senha");
            new SetButtonHover(this.loginButton, Color.Green);
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            StudentController student = new StudentController(0,"Safra","leandrosafra.jconectada@gmail.com","20");
            this.Hide();
            new InitStudentView(student).Show();
        }
    }
}
