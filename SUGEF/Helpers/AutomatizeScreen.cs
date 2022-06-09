using SUGEF.Controller.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUGEF.Helpers
{
    public class AutomatizeScreen
    {
        private void AutomatizeForm(Form actualForm)
        {
            actualForm.Size = new System.Drawing.Size(1080, 720);
            actualForm.ClientSize = new System.Drawing.Size(1080, 720);
            actualForm.StartPosition = FormStartPosition.CenterScreen;
            actualForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public AutomatizeScreen(Form actualForm)
        {
            AutomatizeForm(actualForm);
        }

        public AutomatizeScreen(Form actualForm, string title)
        {
            AutomatizeForm(actualForm);
            actualForm.Text += " " + title + "!";
        }

        public void RenderSidebarStudent(Form context, StudentController student)
        {
            Utils.StudentSidebar studentSidebar = new Utils.StudentSidebar(context,student);
            studentSidebar.Name = "studentSidebar";
            context.Controls.Add(studentSidebar);
        }
        public void RenderSidebarProfessor(Form context, StudentController professor)
        {
            Utils.ProfessorSidebar professorSidebar = new Utils.ProfessorSidebar(context, professor);
            professorSidebar.Name = "professorSidebar";
            context.Controls.Add(professorSidebar);
        }
        public void RenderSidebarDirector(Form context, StudentController director)
        {
            Utils.DirectorSidebar directorSidebar = new Utils.DirectorSidebar(context, director);
            directorSidebar.Name = "directorSidebar";
            context.Controls.Add(directorSidebar);
        }

    }
}
