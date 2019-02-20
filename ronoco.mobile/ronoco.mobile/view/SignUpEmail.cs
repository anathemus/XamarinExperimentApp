using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.view
{
    public class SignUpEmail : ContentPage
    {
        public SignUpEmail()
        {
            
            Label signUpTitle = new Label
            {
                FontFamily = "SFUIDisplay-Medium",
                FontSize = 26,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.FromRgb(80, 80, 100),
                Text = "Sign up"
            };
            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(34, GridUnitType.Absolute) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(signUpTitle, 0, 0);

            Content = grid;
        }
    }
}