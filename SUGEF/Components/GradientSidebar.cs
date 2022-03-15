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
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorLeft, this.ColorRight, 90F);
            Graphics graph = e.Graphics;
            graph.FillRectangle(lgb,this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
