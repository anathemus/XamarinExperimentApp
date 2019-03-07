using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class BottomPolicyToolbar : StackLayout
    {
        public BottomPolicyToolbar()
        {
            BackgroundColor = Color.FromRgb(202, 202, 208);
            Orientation = StackOrientation.Horizontal;
            HeightRequest = 48;
            WidthRequest = App.Current.MainPage.Width;
            Padding = new Thickness(0, 5, 0, 5);
            HorizontalOptions = LayoutOptions.CenterAndExpand;
            VerticalOptions = LayoutOptions.CenterAndExpand;
            // instantiate BottomToolbarButton to use method GetBottomToolbarButton which returns a StackLayout, 
            // requiring paramater of BottomToolbarButton.ButtonType
            BottomToolbarButton toolbarButton = new BottomToolbarButton();

            StackLayout policyButton = toolbarButton.GetBottomToolbarButton(BottomToolbarButton.ButtonType.Policies);
            StackLayout assetsButton = toolbarButton.GetBottomToolbarButton(BottomToolbarButton.ButtonType.Assets);
            StackLayout scoreButton = toolbarButton.GetBottomToolbarButton(BottomToolbarButton.ButtonType.Score);
            StackLayout adviceButton = toolbarButton.GetBottomToolbarButton(BottomToolbarButton.ButtonType.Advice);

            Children.Add(policyButton);
            Children.Add(assetsButton);
            Children.Add(scoreButton);
            Children.Add(adviceButton);
        }
    }
}