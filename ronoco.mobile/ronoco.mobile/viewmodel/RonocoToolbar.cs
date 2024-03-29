﻿using System;
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
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.FillAndExpand;
            return this;
        }

        public RonocoToolbar MakeBottomRonocoToolbar(Color backgroundColor, Color fontColor)
        {
            RonocoToolbar bottomToolbar = new RonocoToolbar();
            bottomToolbar.BackgroundColor = backgroundColor;
            bottomToolbar.Orientation = StackOrientation.Horizontal;
            bottomToolbar.HeightRequest = 48;
            bottomToolbar.WidthRequest = App.Current.MainPage.Width;
            bottomToolbar.Padding = new Thickness(0, 5, 0, 5);
            bottomToolbar.HorizontalOptions = LayoutOptions.CenterAndExpand;
            bottomToolbar.VerticalOptions = LayoutOptions.CenterAndExpand;
            // instantiate BottomToolbarButton to use method GetBottomToolbarButton which returns a StackLayout, 
            // requiring paramater of BottomToolbarButton.ButtonType
            RonocoToolbarButton toolbarButton = new RonocoToolbarButton();

            StackLayout policyButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Policies, fontColor);
            StackLayout assetsButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Assets, fontColor);
            StackLayout scoreButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Score, fontColor);
            StackLayout adviceButton = toolbarButton.GetBottomToolbarButton(RonocoToolbarButton.ButtonType.Advice, fontColor);

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