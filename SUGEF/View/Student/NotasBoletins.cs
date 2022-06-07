using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class NotasBoletins : Form
    {
        public NotasBoletins()
        {
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this);
            InitializeComponent();
        }

      
    }
}
