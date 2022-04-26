using System;
using System.Windows.Forms;
using System.Drawing;

namespace SUGEF.Helpers
{
    internal class SetButtonHover
    {
        readonly Button button;
        readonly Color color;
        public SetButtonHover(Button button, Color color)
        {
            this.button = button;
            this.color = color;
            this.button.ForeColor = color;
            this.button.BackColor = Color.White;
            this.button.MouseEnter += HoverIn;
            this.button.MouseLeave += HoverOut;

        }
        private void HoverIn(object sender, EventArgs e)
        {
            this.button.BackColor = this.color;
            this.button.ForeColor = Color.White;

        }
        private void HoverOut(object sender, EventArgs e)
        {
            this.button.BackColor = Color.White;
            this.button.ForeColor = this.color;
        }
    }
}
