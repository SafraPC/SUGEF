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

            actualForm.StartPosition = FormStartPosition.CenterScreen;
            actualForm.MaximizeBox = false;
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

        public void RenderSidebarStudent(Form context, UserModel student)
        {
            Utils.StudentSidebar studentSidebar = new Utils.StudentSidebar(context,student);
            studentSidebar.Name = "studentSidebar";
            context.Controls.Add(studentSidebar);
        }
        public void RenderSidebarProfessor(Form context, UserModel professor)
        {
            Utils.ProfessorSidebar professorSidebar = new Utils.ProfessorSidebar(context, professor);
            professorSidebar.Name = "professorSidebar";
            context.Controls.Add(professorSidebar);
        }
        public void RenderSidebarDirector(Form context, UserModel director)
        {
            Utils.DirectorSidebar directorSidebar = new Utils.DirectorSidebar(context, director);
            directorSidebar.Name = "directorSidebar";
            context.Controls.Add(directorSidebar);
        }

    }
}
