using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUGEF.Helpers
{
    internal class ShowForm
    {
        public ShowForm(Form previousForm, Form newForm)
        {
            previousForm.Hide();
            newForm.Show();
            newForm.FormClosing += Closing;
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
