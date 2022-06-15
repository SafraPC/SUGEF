using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Components.Cards
{
    public class ProfessorsCard
    {
        public Panel CreateTurmasPanel(string titleText, string descriptionText)
        {
            Panel panel = new Panel();
            panel.Size = new Size(345, 290);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label title = new Label();
            title.Font = new Font("Cambria", 18, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Location = new Point(0, 20);
            title.Size = new Size(345, 30);
            title.Text = titleText;
            title.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(title);

            Label description = new Label();
            description.Font = new Font("Cambria", 13, FontStyle.Regular);
            description.ForeColor = Color.Black;
            description.Location = new Point(0, 65);
            description.TextAlign = ContentAlignment.MiddleCenter;
            description.Size = new Size(345, 150);
            description.Text = descriptionText;
            panel.Controls.Add(description);

            return panel;
        }
    }
}
