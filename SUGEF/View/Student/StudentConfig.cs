﻿using SUGEF.Controller.Student;
using SUGEF.Helpers;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class StudentConfig : Form
    {
        UserController student;
        public StudentConfig(UserController student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);
        }
    }
}
