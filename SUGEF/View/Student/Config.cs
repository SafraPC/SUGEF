using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class Config : Form
    {
        public Config()
        {
            new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            InitializeComponent();
        }
    }
}
