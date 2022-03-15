using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SUGEF.Helpers
{
    internal class SetButtonHover
    {
        readonly Button button;
        public SetButtonHover(Button button)
        {
            this.button = button;
            this.button.MouseEnter += HoverIn;
            this.button.MouseLeave += HoverOut;

        }
        private void HoverIn(object sender, EventArgs e)
        {
            this.button.BackColor = Color.Green;
            this.button.ForeColor = Color.White;

        }
        private void HoverOut(object sender, EventArgs e)
        {
            this.button.BackColor = Color.White;
            this.button.ForeColor = Color.Green;
        }
    }
}
