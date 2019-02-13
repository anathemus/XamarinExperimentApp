using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.viewmodel;

namespace ronoco.mobile.model
{
    class CarouselItemTemplate : ContentView
    {
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
        public string ImageSourceString { get; set; }

        public Grid CarouselTemplate(ItemsSource pageItems, int index)
        {
            // IMPORTANT NOTE! When creating attributes for template, it is not enough to instantiate!
            // The attributes must be initialized with at least one property to be recognized
            // otherwise they appear NULL
            Grid carouselLayout = new Grid();

            Label header = new Label
            {
                FontFamily = "SFUIDisplay-Medium",
                FontSize = 26,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = HeaderText
            };

            Image image = new Image
            {
                Source = ImageSource.FromFile(ImageSourceString),    
            };

            Label description = new Label
            {
                FontFamily = "SFUIText-Medium",
                FontSize = 12,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = DescriptionText
            };

            DotButtonsLayout buttonsLayout = new DotButtonsLayout(3, Color.DimGray, 2, index);

            Button signInButton = new Button
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

            Button signUpEmailButton = new Button
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
                BorderWidth = 1
            };

            Button signUpFacebookButton = new Button
            {
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.White,
                BackgroundColor = Color.FromRgb(59, 89, 152),
                BorderColor = Color.FromRgb(59, 89, 152),
                HorizontalOptions = LayoutOptions.Center,
                Text = "SIGN UP",
                CornerRadius = 45,
                WidthRequest = 132,
                HeightRequest = 48,
                BorderWidth = 1
            };

            Button signUpGoogleButton = new Button
            {
                FontFamily = "SFUIText-Bold",
                FontSize = 16,
                TextColor = Color.White,
                BackgroundColor = Color.FromRgb(211, 72, 54),
                BorderColor = Color.FromRgb(211, 72, 54),
                HorizontalOptions = LayoutOptions.Center,
                Text = "SIGN UP",
                CornerRadius = 45,
                WidthRequest = 132,
                HeightRequest = 48,
                BorderWidth = 1
            };

            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(220, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(25, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(32, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            carouselLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            carouselLayout.Children.Add(image, 0, 0);
            carouselLayout.Children.Add(header, 0, 1);
            carouselLayout.Children.Add(description, 0, 2);
            carouselLayout.Children.Add(buttonsLayout, 0, 3);

            carouselLayout.Children.Add(signInButton, 0, 4);
            carouselLayout.Children.Add(signUpEmailButton, 0, 6);
            carouselLayout.Children.Add(signUpFacebookButton, 0, 8);
            carouselLayout.Children.Add(signUpGoogleButton, 0, 10);

            return carouselLayout;
        }
    }
}
