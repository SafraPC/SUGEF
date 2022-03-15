using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new SetPlaceholder(this.inputLogin,"Insira seu Login");
            new SetPlaceholder(this.inputPassword, "Insira sua Senha");
            new SetButtonHover(this.loginButton);
        }
    }
}
