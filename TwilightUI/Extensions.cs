using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightUI
{
    public static class Extensions
    {
        public static Color Clr(this ThemeManager.ThemeColors clr)
        {
            return ThemeManager.Colors[clr];
        }

        public static SolidBrush Brush(this Color clr)
        {
            return new SolidBrush(clr);
        }

        public static Pen Pen(this Color clr, float width = 1f)
        {
            return new System.Drawing.Pen(clr, width);
        }

        public static Font Size(this Font font, float size)
        {
            return new Font(font.FontFamily, size);
        }

        public static Point Center(this Rectangle rect1, Size rect2)
        {
            return new Point(rect1.Width / 2 - rect2.Width / 2, rect1.Height / 2 - rect2.Height / 2);
        }

        public static Color Opacity(this Color clr, int opacity)
        {
            return Color.FromArgb(opacity, clr);
        }
    }
}
