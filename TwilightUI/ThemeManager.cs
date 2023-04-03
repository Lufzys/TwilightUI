using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightUI
{
    public class ThemeManager
    {
        public static readonly Dictionary<ThemeColors, Color> Colors = new Dictionary<ThemeColors, Color>()
        {
            {ThemeColors.UI_Main, Color.FromArgb(102, 14, 196)},
            {ThemeColors.Form, Color.FromArgb(24, 24, 24)},
            {ThemeColors.Main, Color.FromArgb(17, 17, 17)},
            {ThemeColors.Border, Color.FromArgb(34, 34, 34)},
            {ThemeColors.Text, Color.FromArgb(244, 244, 244)},
        };

        public enum ThemeColors
        {
            UI_Main,
            Form,
            Main,
            Border,
            Text
        }

        public static Font DefaultFont = new Font("Segoe UI", 9f);
        public static SmoothingMode SmoothingMode = SmoothingMode.HighQuality;
        public static TextRenderingHint TextRenderingHint = TextRenderingHint.AntiAlias;
    }
}
