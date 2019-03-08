using Xamarin.Forms;
using System.Collections.Generic;
using FFImageLoading.Svg.Forms;

namespace ronoco.mobile.viewmodel
{
    public class Icon : Image
    {
        public enum IconType
        {
            Regular,
            Solid,
            Brand
        }

        public IconType Type { get; set; }

        public Icon MakeIconImage(IconType iconType, string unicodeIcon, Color iconColor)
        {
            Icon icon = new Icon();
            string iconFontPath = MakeIcon(iconType);

            icon.Source = new FontImageSource
            {
                Color = iconColor,
                FontFamily = iconFontPath,
                Size = 20,
                Glyph = unicodeIcon
            };

            return icon;
        }

        public ToolbarItem MakeToolbarIconText(IconType iconType, string unicodeIcon, Color iconColor)
        {
            ToolbarItem toolbarItem = new ToolbarItem
            {
                Text = unicodeIcon
            };

            return toolbarItem;
        }

        string MakeIcon(IconType type)
        {
            string fontPath = "";
            switch (type)
            {
                case IconType.Regular:
                    switch (Device.RuntimePlatform)
                    {
                        case Device.iOS:
                            fontPath = "Font Awesome 5 Free Regular";
                            break;
                        case Device.Android:
                            fontPath = "fa-regular-400.ttf#Font Awesome 5 Free Regular";
                            break;
                        default:
                            break;
                    }
                    break;
                case IconType.Solid:
                    switch (Device.RuntimePlatform)
                    {
                        case Device.iOS:
                            fontPath = "Font Awesome 5 Free Solid";
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
                            fontPath = "Font Awesome 5 Free Brands";
                            break;
                        case Device.Android:
                            fontPath = "fa-brands-400.ttf#Font Awesome 5 Free Brands";
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