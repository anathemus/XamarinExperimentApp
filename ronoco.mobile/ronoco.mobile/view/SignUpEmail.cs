﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ronoco.mobile.model;
using ronoco.mobile.view;
using ronoco.mobile.viewmodel;
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

            PolicyCell cell = new PolicyCell();
            cell.BindingContext = new DefaultAccount().Policies;

            Button emailEntryField = new Button
            {
                BackgroundColor = Color.LightGray,
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.Black,
                Text = "SKIP TO POLICIES",
                HorizontalOptions = LayoutOptions.Center,
                CornerRadius = 45,
                WidthRequest = 272,
                HeightRequest = 48
            };
            emailEntryField.Pressed += EmailEntryField_Pressed;

            Entry emailEntry = new Entry
            {
                
            };
            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(34, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(signUpTitle, 0, 0);
            grid.Children.Add(emailEntryField, 0, 2);
            grid.Children.Add(cell.View, 0, 4);

            Content = grid;
        }

        private void EmailEntryField_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolicyListView());
        }
    }
}