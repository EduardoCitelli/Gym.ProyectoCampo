namespace Gym.View
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class PanelColores : Panel
    {
        public PanelColores()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        [Category("Colores")]
        public Color ColorArriba { get; set; }

        [Category("Colores")]
        public Color ColorAbajo { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0) return;

            var lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorArriba, this.ColorAbajo, LinearGradientMode.ForwardDiagonal);

            e.Graphics.FillRectangle(lgb, this.ClientRectangle);

            base.OnPaint(e);
        }
    }
}