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

namespace SUGEF.View.Student
{
    public partial class ConfigUser : Form
    {
        public ConfigUser(StudentController student)
        {
            new AutomatizeScreen(this, "Bem-vindo ao SUGEF!");
            InitializeComponent();
        }

      
    }
}
