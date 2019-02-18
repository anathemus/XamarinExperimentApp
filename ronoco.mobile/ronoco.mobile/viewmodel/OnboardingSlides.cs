using ronoco.mobile.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class OnboardingSlides : ContentView
    {
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
        public string ImageSourceString { get; set; }
        public DataTemplate carouselTemplate { get; set; }
        private int itemsSourceCount { get; set; }

        public OnboardingSlides()
        {
            OnboardingItemsSource carouselItems = new OnboardingItemsSource();
            ObservableCollection<ItemsSource> itemsSource = carouselItems.AllItems();

            itemsSourceCount = itemsSource.Count;

            carouselTemplate = new DataTemplate(() =>
            {

                GridItemsLayout gridLayout = new GridItemsLayout(ItemsLayoutOrientation.Horizontal);
                gridLayout.SnapPointsAlignment = SnapPointsAlignment.Center;
                gridLayout.SnapPointsType = SnapPointsType.Mandatory;

                Grid slideGrid = new Grid();

                Image slideImage = new Image();
                slideImage.SetBinding(Image.SourceProperty, "ImageFile");

                Label slideHeader = new Label
                {
                    FontFamily = "SFUIDisplay-Medium",
                    FontSize = 26,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                };
                slideHeader.SetBinding(Label.TextProperty, "HeaderText");

                Label slideDescription = new Label
                {
                    FontFamily = "SFUIText-Medium",
                    FontSize = 12,
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = DescriptionText
                };
                slideDescription.SetBinding(Label.TextProperty, "DescriptionText");

                slideGrid.RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(34, GridUnitType.Absolute)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                };

                slideGrid.ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                };

                slideGrid.Children.Add(slideImage, 0, 0);
                slideGrid.Children.Add(slideHeader, 0, 1);
                slideGrid.Children.Add(slideDescription, 0, 2);

                return new ContentView { Content = slideGrid };
            });
        }
    }
}
