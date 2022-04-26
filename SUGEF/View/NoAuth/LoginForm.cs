using SUGEF.Helpers;
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
    }
}
