using System;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Helpers
{
    internal class SetHover
    {

        private Panel panel;
        readonly Color hoverColor = Color.FromArgb(30, 60, 114);
        public void setHover(Panel panel)
        {
            this.panel = panel;
            this.panel.MouseLeave += RemoveHover;
            this.panel.MouseEnter += AddHover;

        }
        private void RemoveHover(object sender, EventArgs e)
        {
            this.panel.BackColor = Color.Transparent;
        }

        private void AddHover(object sender, EventArgs e)
        {
            this.panel.BackColor = hoverColor;
        }

    }
}
