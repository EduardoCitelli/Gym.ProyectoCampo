namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class GridColores : DataGridView
    {
        [Category("Colores")]
        public Color ColorAbajo { get; set; }

        [Category("Colores")]
        public Color ColorArriba { get; set; }

        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);

            using (var lgb = new LinearGradientBrush(clipBounds, this.ColorArriba, this.ColorAbajo, LinearGradientMode.ForwardDiagonal))
            {
                lgb.GammaCorrection = true;
                graphics.FillRectangle(lgb, clipBounds);
            }

            using (var lgb2 = new LinearGradientBrush(gridBounds, this.ColorArriba, this.ColorAbajo, LinearGradientMode.ForwardDiagonal))
            {
                lgb2.GammaCorrection = true;

                graphics.FillRectangle(lgb2, gridBounds);
            }
        }
    }
}