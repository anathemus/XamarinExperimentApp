using Xamarin.Forms;
using System.Collections.Generic;
using FFImageLoading.Svg.Forms;

namespace ronoco.mobile.viewmodel
{
    public class Icon : Image
    {
        public enum IconType
        {
            Solid,
            Brand
        }

        public IconType Type { get; set; }

        public Icon MakeIconImage(IconType iconType, string unicodeIcon, Color iconColor)
        {
            Icon icon = new Icon();
            string iconFontPath = MakeIconPath(iconType);

            icon.Source = new FontImageSource
            {
                Color = iconColor,
                FontFamily = iconFontPath,
                Size = 20,
                Glyph = unicodeIcon,
            };

            return icon;
        }

        public Icon MakeIconText(string iconText, Color iconColor)
        {
            Icon icon = new Icon();

            icon.Source = new FontImageSource
            {
                Color = iconColor,
                FontFamily = "SFUIText-Semibold",
                Size = 16,
                Glyph = iconText
            };

            return icon;
        }

        public string MakeIconPath(IconType type)
        {
            string fontPath = "";
            switch (type)
            {
                case IconType.Solid:
                    switch (Device.RuntimePlatform)
                    {
                        case Device.iOS:
                            fontPath = "Font Awesome 5 Free";
                            break;
                        case Device.Android:
                            fontPath = "fa-solid-900.ttf#Font Awesome 5 Free Solid";
                            break;
                        default:
                            break;
                    }
                    break;
                case IconType.Brand:
                    switch (Device.RuntimePlatform)
                    {
                        case Device.iOS:
                            fontPath = "Font Awesome 5 Brands";
                            break;
                        case Device.Android:
                            fontPath = "fa-brands-400.ttf#Font Awesome 5 Free Brands Regular";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    throw new System.Exception("ERROR: IconType not specified!");
            }



            return fontPath;
        }
    }
}