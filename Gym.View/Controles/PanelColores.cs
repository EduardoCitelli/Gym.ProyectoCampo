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

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    if (this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0) return;

        //    using (var brush = new LinearGradientBrush(this.ClientRectangle, this.ColorArriba, this.ColorAbajo, LinearGradientMode.ForwardDiagonal))
        //    {
        //        var b = new ColorBlend
        //        {
        //            Positions = new[] { 0, 3 / 10f, 1 },
        //            Colors = new[] { this.ColorArriba, this.ColorAbajo, this.ColorAbajo }
        //        };

        //        brush.InterpolationColors = b;

        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}

        //protected override void OnPaintBackground(PaintEventArgs pevent)
        //{
        //    if (this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0) return;

        //    using (var brush = new LinearGradientBrush(this.ClientRectangle, Color.Transparent, Color.Transparent, LinearGradientMode.ForwardDiagonal))
        //    {
        //        var b = new ColorBlend
        //        {
        //            Positions = new[] { 0, 3 / 10f, 1 },
        //            Colors = new[] { Color.WhiteSmoke, Color.LightSteelBlue, Color.LightSteelBlue }
        //        };

        //        brush.InterpolationColors = b;
        //        pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}
    }
}
