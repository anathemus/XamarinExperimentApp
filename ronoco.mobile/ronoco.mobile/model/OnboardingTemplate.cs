using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.viewmodel;
using ronoco.mobile.view;

namespace ronoco.mobile.model
{
    class OnboardingTemplate : ContentView
    {
        public Button signInButton { get; set; }
        public Button signUpEmailButton { get; set; }
        public Button signUpFacebookButton { get; set; }
        public Button signUpGoogleButton { get; set; }
        public OnboardingTemplate()
        {
            signInButton = new Button
            {
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.FromRgb(70, 120, 200),
                BackgroundColor = Color.White,
                BorderColor = Color.FromRgb(70, 120, 200),
                HorizontalOptions = LayoutOptions.Center,
                Text = "SIGN IN",
                CornerRadius = 45,
                WidthRequest = 272,
                HeightRequest = 48,
                BorderWidth = 1
            };

            signUpEmailButton = new Button
            {
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.White,
                BackgroundColor = Color.FromRgb(70, 120, 200),
                BorderColor = Color.FromRgb(70, 120, 200),
                HorizontalOptions = LayoutOptions.Center,
                Text = "SIGN UP WITH EMAIL",
                CornerRadius = 45,
                WidthRequest = 272,
                HeightRequest = 48,
                BorderWidth = 1,
            };
            signUpEmailButton.Pressed += SignUpEmailButton_Pressed;

            signUpFacebookButton = new Button
            {
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.White,
                BackgroundColor = Color.FromRgb(59, 89, 152),
                BorderColor = Color.FromRgb(59, 89, 152),
                HorizontalOptions = LayoutOptions.End,
                Text = "SIGN UP",
                CornerRadius = 45,
                WidthRequest = 132,
                HeightRequest = 48,
                BorderWidth = 1
            };

            signUpGoogleButton = new Button
            {
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.White,
                BackgroundColor = Color.FromRgb(211, 72, 54),
                BorderColor = Color.FromRgb(211, 72, 54),
                HorizontalOptions = LayoutOptions.Start,
                Text = "SIGN UP",
                CornerRadius = 45,
                WidthRequest = 132,
                HeightRequest = 48,
                BorderWidth = 1
            };
        }

        private void SignUpEmailButton_Pressed(object sender, EventArgs e)
        {
            RonocoNavigationPage navigation = new RonocoNavigationPage();
            navigation = navigation.MakeWhiteBackButtonNavPage(new SignUpEmail());
            App.Current.MainPage = navigation;
            // navigation.PushAsync(new SignUpEmail());
        }
    }
}
