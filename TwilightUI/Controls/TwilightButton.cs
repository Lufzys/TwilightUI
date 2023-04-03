using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwilightUI.Controls
{
    public class TwilightButton : Control
    {
        public TwilightButton() 
        {
            this.Size = new Size(75, 25);
            this.Cursor = Cursors.Hand;
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private string context = string.Empty;
        public string Context { get { return context; }  set { context = value; this.Invalidate(); } }

        private int opacity = 0;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            opacity = 128;
            this.Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            opacity = 64;
            this.Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            opacity = 64;
            this.Invalidate();
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            opacity = 0;
            this.Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Setup graphics
            var gfx = e.Graphics;
            gfx.SmoothingMode = ThemeManager.SmoothingMode;
            gfx.TextRenderingHint = ThemeManager.TextRenderingHint;

            // Draw base
            var clientRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            gfx.FillRectangle(ThemeManager.ThemeColors.Main.Clr().Brush(), clientRectangle);
            gfx.FillRectangle(Color.Black.Opacity(opacity).Brush(), clientRectangle);

            // Draw text
            var textSize = gfx.MeasureString(Context, ThemeManager.DefaultFont).ToSize();
            gfx.DrawString(Context, ThemeManager.DefaultFont, ThemeManager.ThemeColors.Text.Clr().Brush(), clientRectangle.Center(textSize));

            // Draw border
            gfx.DrawRectangle(ThemeManager.ThemeColors.Border.Clr().Pen(), clientRectangle);
            base.OnPaint(e);
        }
    }
}
