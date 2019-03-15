using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
            RonocoToolbar toolbar = new RonocoToolbar().MakeRonocoToolbar(Color.White);
            Icon icon = new Icon().MakeIconImage(ronoco.mobile.viewmodel.Icon.IconType.Solid, "\uf060", Color.FromRgb(80, 80, 100));
            TapGestureRecognizer tap = new TapGestureRecognizer();
            RonocoToolbarButton toolbarButton = new RonocoToolbarButton
            {
                Children = { icon }
            };
            toolbarButton.GestureRecognizers.Add(tap);
            toolbarButton.HorizontalOptions = LayoutOptions.Start;
            toolbarButton.VerticalOptions = LayoutOptions.Center;
            toolbarButton.BackgroundColor = Color.White;
            (toolbarButton.GestureRecognizers.ElementAt(0) as TapGestureRecognizer).Tapped += BackButton_Tapped;

            toolbar.Padding = new Thickness(0, 15, 0, 0);
            toolbar.VerticalOptions = LayoutOptions.Center;
            toolbar = toolbar.AddToolbarButton(toolbar, toolbarButton);

            Padding = new Thickness(24, 0);
            BackgroundColor = Color.White;

            Label signUpTitle = new Label
            {
                FontFamily = "SFUIDisplay-Medium",
                FontSize = 26,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.FromRgb(80, 80, 100),
                Text = "Sign up",
            };

            EntryField emailEntry = new EntryField().CreateEntryField(new Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, 
                "\uf0e0", Color.FromRgb(80, 80, 100)), Keyboard.Email, false);

            EntryField passEntry = new EntryField().CreateEntryField(new Icon().MakeIconImage(viewmodel.Icon.IconType.Solid,
                "\uf023", Color.FromRgb(80, 80, 100)), Keyboard.Default, true);

            Button signUpSubmit = new Button
            {
                BackgroundColor = Color.FromRgb(70, 120, 200),
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.White,
                Text = "GET STARTED",
                HorizontalOptions = LayoutOptions.Center,
                CornerRadius = 25,
                WidthRequest = 272,
                HeightRequest = 48
            };
            signUpSubmit.Pressed += SignUpSubmit_Pressed;



            Grid grid = constants.RonocoGrid.RonocoBackArrowGrid;

            grid.BackgroundColor = Color.White;
            grid.Children.Add(toolbar, 0, 0);
            Grid.SetColumnSpan(toolbar, 3);
            grid.Children.Add(signUpTitle, 1, 1);
            grid.Children.Add(emailEntry, 1, 3);
            grid.Children.Add(passEntry, 1, 5);
            grid.Children.Add(signUpSubmit, 1, 7);

            Content = grid;
        }

        private void BackButton_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void SignUpSubmit_Pressed(object sender, EventArgs e)
        {
            PolicyListView listView = new PolicyListView();

            await Navigation.PushAsync(listView);
        }
    }
}