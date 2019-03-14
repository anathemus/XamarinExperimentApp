using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class RonocoToolbar : StackLayout
    {
        public enum ToolbarType
        {
            Top,
            Bottom
        }

        public RonocoToolbar MakeRonocoToolbar(Color color)
        {
            Orientation = StackOrientation.Horizontal;
            BackgroundColor = color;
            HeightRequest = 64;
            WidthRequest = App.Current.MainPage.Width;
            Padding = new Thickness(0, 0, 0, 0);
            HorizontalOptions = LayoutOptions.CenterAndExpand;
            VerticalOptions = LayoutOptions.Center;
            return this;
        }

        public RonocoToolbar MakeBottomRonocoToolbar()
        {
            RonocoToolbar bottomToolbar = new RonocoToolbar();
            bottomToolbar.BackgroundColor = Color.FromRgb(202, 202, 208);
            bottomToolbar.Orientation = StackOrientation.Horizontal;
            bottomToolbar.HeightRequest = 48;
            bottomToolbar.WidthRequest = App.Current.MainPage.Width;
            bottomToolbar.Padding = new Thickness(0, 5, 0, 5);
            bottomToolbar.HorizontalOptions = LayoutOptions.CenterAndExpand;
            bottomToolbar.VerticalOptions = LayoutOptions.CenterAndExpand;
            // instantiate BottomToolbarButton to use method GetBottomToolbarButton which returns a StackLayout, 
            // requiring paramater of BottomToolbarButton.ButtonType
            RonocoToolbarButton toolbarButton = new RonocoToolbarButton();

            StackLayout policyButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Policies);
            StackLayout assetsButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Assets);
            StackLayout scoreButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Score);
            StackLayout adviceButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Advice);

            bottomToolbar.Children.Add(policyButton);
            bottomToolbar.Children.Add(assetsButton);
            bottomToolbar.Children.Add(scoreButton);
            bottomToolbar.Children.Add(adviceButton);

            return bottomToolbar;
        }

        public RonocoToolbar AddToolbarButton(RonocoToolbar toolbar, RonocoToolbarButton button)
        {
            toolbar.Children.Add(button);
            return toolbar;
        }
    }
}