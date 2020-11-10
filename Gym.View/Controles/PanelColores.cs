namespace Gym.View
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class PanelColores : Panel
    {
        [Category("Colores")]
        public Color ColorArriba { get; set; }

        [Category("Colores")]
        public Color ColorAbajo { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            var lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorArriba, this.ColorAbajo, LinearGradientMode.ForwardDiagonal);

            var g = e.Graphics;

            g.FillRectangle(lgb, this.ClientRectangle);

            base.OnPaint(e);
        }
    }
}
