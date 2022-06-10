﻿using SUGEF.Components;
using SUGEF.Controller.Student;
using SUGEF.View.Professor;
using SUGEF.View.Student;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class ProfessorSidebar : Panel
    {
        private Form form;
        private UserController professor;
        public ProfessorSidebar(Form form, UserController professor)
        {
            this.form = form;
            this.professor = professor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 114);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 720);
            base.OnPaint(e);
            //Create picture and data
            SidebarProps sidebarElements = new SidebarProps(this, this.form);

            sidebarElements.CreateHeader(this.professor.UserName,this.professor.UserCpf);
            //Create Panels
            sidebarElements.CreateSidebarElement("Turmas", "users", 150, new ProfessorIndex(this.professor));

            sidebarElements.CreateSidebarElement("Configurações","settings",600,new ProfessorIndex(this.professor));
            sidebarElements.CreateSidebarElement("Sair", "logout", 650, new LoginForm());
        }

    }
}