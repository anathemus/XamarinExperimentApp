using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    class VariableLabel : Label
    {
        public Label CreateVariableLabel(Binding binding)
        {
            Label variableLabel = new Label();
            variableLabel.FontFamily = "SFUIText-Semibold";
            variableLabel.FontSize = 16;
            variableLabel.TextColor = Color.FromRgb(80, 80, 100);
            variableLabel.HorizontalTextAlignment = TextAlignment.End;
            variableLabel.SetBinding(Label.TextProperty, binding);
            variableLabel.VerticalOptions = LayoutOptions.Center;

            return variableLabel;
        }
    }
}
