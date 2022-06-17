using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SUGEF.Utils
{
    class GradientSidebar:Panel
    {
      
        public Color ColorLeft { get; set; }
        public Color ColorRight { get; set; }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            this.ColorLeft = Color.FromArgb(70, 120, 222);
            this.ColorRight = Color.FromArgb(30,60,114);
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorLeft, this.ColorRight, 90F);
            Graphics graph = e.Graphics;
            graph.FillRectangle(lgb,this.ClientRectangle);
            this.Location = new Point(0, 0);
            this.Size = new Size(290, 2000);

            Label title = new Label();
            title.Size = new Size(this.Width, 100);
            title.Text = "SUGEF";
            title.Font = new Font("Segoe MDL2 Assets", 36, FontStyle.Italic);
            title.BackColor = Color.Transparent;
            title.ForeColor = Color.White;
            title.Location = new Point(0, 40);
            title.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(title);

            Label description = new Label();
            description.Size = new Size(this.Width, 100);
            description.Text = "Sistema Unificado de Gestão Escolar Facilitado";
            description.BackColor = Color.Transparent;
            description.Location = new Point(0, 125);
            description.TextAlign = ContentAlignment.MiddleCenter;
            description.Font = new Font("Segoe MDL2 Assets", 16, FontStyle.Italic);
            description.ForeColor = Color.White;
            this.Controls.Add(description);

            base.OnPaint(e);

           

        }

    }
}
