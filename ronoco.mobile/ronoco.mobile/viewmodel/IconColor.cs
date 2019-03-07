using FFImageLoading.Svg.Forms;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class IconColor
    {
        public Color RGBColor { get; set; }
        public string SourcePath { get; set; }
        public IconColor()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("fill: rgb(0, 0, 0);", GetRGBFill(RGBColor));

            var icon = new SvgCachedImage
            {
                ReplaceStringMap = dict,
                Source = SourcePath,
            };
        }

        public static string GetRGBFill(Color color)
        {
            var red = (int)(color.R * 255);
            var green = (int)(color.G * 255);
            var blue = (int)(color.B * 255);
            var rgbFill = $"fill: rgb({red},{green},{blue});";
            return rgbFill;
        }
    }
}