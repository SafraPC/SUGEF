using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class MenuItem:Panel
    {
        //readonly Color hoverColor = Color.FromArgb(30, 60, 114);

        public MenuItem(Label title)
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(290, 44);
            this.Container.Add(title);
        }
    }
}
