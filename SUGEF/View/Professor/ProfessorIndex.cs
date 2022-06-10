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
        UserController professor;
        public ProfessorIndex(UserController professor)
        {
            InitializeComponent();
            this.professor = professor;
            AutomatizeScreen formConfig = new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            formConfig.RenderSidebarProfessor(this, professor);
        }
    }
}
