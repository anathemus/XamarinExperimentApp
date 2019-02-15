using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.viewmodel;

namespace ronoco.mobile.model
{
    class OnboardingTemplate : ContentView
    {
        // FlexLayout to animate swiping "slides"
        private OnboardingSlides slides { get; set; }
        private int slideIndex { get; set; }
        private int itemsSourceCount { get; set; }

        public Grid CarouselTemplate(int itemsSourceCount)
        {
            this.itemsSourceCount = itemsSourceCount;

            // IMPORTANT NOTE! When creating attributes for template, it is not enough to instantiate!
            // The attributes must be initialized with at least one property to be recognized
            // otherwise they appear NULL
            Grid carouselLayout = new Grid();

            slides = new OnboardingSlides();

            DotButtonsLayout buttonsLayout = new DotButtonsLayout(itemsSourceCount, Color.FromRgb(70, 120, 200), 8);
            buttonsLayout.SetOpacityIndex(slideIndex);

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
                HorizontalOptions = LayoutOptions.End,
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
                HorizontalOptions = LayoutOptions.Start,
                Text = "SIGN UP",
                CornerRadius = 45,
                WidthRequest = 132,
                HeightRequest = 48,
                BorderWidth = 1
            };

            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(344, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(32, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            carouselLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            carouselLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            carouselLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8, GridUnitType.Absolute)});
            carouselLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});

            carouselLayout.BackgroundColor = Color.White;

            var carouselSlides = slides.OnboardingCarouselSlides();


            // must use baseclass Grid to SetColumnSpan, cannot use instantiated object
            carouselLayout.Children.Add(carouselSlides, 0, 0);
            Grid.SetColumnSpan(carouselSlides, 3);
            carouselLayout.Children.Add(buttonsLayout, 0, 1);
            Grid.SetColumnSpan(buttonsLayout, 3);

            carouselLayout.Children.Add(signInButton, 0, 7);
            Grid.SetColumnSpan(signInButton, 3);
            carouselLayout.Children.Add(signUpEmailButton, 0, 5);
            Grid.SetColumnSpan(signUpEmailButton, 3);
            carouselLayout.Children.Add(signUpFacebookButton, 0, 3);
            carouselLayout.Children.Add(signUpGoogleButton, 2, 3);

            return carouselLayout;
        }

        public int GetSlideIndex()
        {
            return slideIndex;
        }

        public void SetSlideIndex(int slideIndex)
        {
            this.slideIndex = slideIndex;
        }

        public int GetItemsSourceCount()
        {
            return itemsSourceCount;
        }

        public void SetItemsSourceCount(int itemsSourceCount)
        {
            this.itemsSourceCount = itemsSourceCount;
        }
    }
}
