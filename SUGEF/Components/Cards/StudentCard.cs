using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Components.Cards
{
    public class StudentCard
    {
        public Panel CreateTurmasPanel()
        {
            Panel panel = new Panel();
            panel.Size = new Size(345, 290);
            panel.BackColor = Color.LightGray;
            panel.BorderStyle = BorderStyle.FixedSingle;

            return panel;
        }

        public Panel CreateStudentCard()
        {
            return new Panel();
        }

    }
}
