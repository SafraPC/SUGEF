using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Director
{
    public partial class DirectorIndex : Form
    {
        UserModel director = null;
        public DirectorIndex(UserModel director)
        {
            InitializeComponent();
            this.director = director;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarDirector(this, director);
        }
    }
}
