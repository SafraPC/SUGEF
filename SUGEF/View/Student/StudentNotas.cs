using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class StudentNotas : Form
    {
        UserModel student;
        public StudentNotas(UserModel student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
