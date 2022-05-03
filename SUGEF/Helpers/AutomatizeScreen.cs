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

    }
}
