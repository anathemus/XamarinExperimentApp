using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    class StaticLabel : Label
    {
        public Label CreateStaticLabel(string labelText)
        {
            Label staticLabel = new Label();
            staticLabel.FontFamily = "SFUIText-Light";
            staticLabel.FontSize = 16;
            staticLabel.TextColor = Color.FromRgb(80, 80, 100);
            staticLabel.Text = labelText;
            staticLabel.VerticalOptions = LayoutOptions.Center;

            return staticLabel;
        }
    }
}
