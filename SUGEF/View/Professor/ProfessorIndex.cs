using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUGEF.View.Professor
{
    public partial class ProfessorIndex : Form
    {
        UserModel professor;
        public ProfessorIndex(UserModel professor)
        {
            InitializeComponent();
            this.professor = professor;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarProfessor(this, professor);
        }
    }
}
