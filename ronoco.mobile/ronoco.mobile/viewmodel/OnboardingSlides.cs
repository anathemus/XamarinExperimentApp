using ronoco.mobile.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class OnboardingSlides : CarouselView
    {
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
        public string ImageSourceString { get; set; }
        private CarouselView carousel { get; set; }
        private int itemsSourceCount { get; set; }
        ObservableCollection<Frame> frameCollection { get; set; }

        public CarouselView OnboardingCarouselSlides()
        {
            carousel = new CarouselView();

            GridItemsLayout gridLayout = new GridItemsLayout(ItemsLayoutOrientation.Horizontal);
            gridLayout.SnapPointsAlignment = SnapPointsAlignment.Center;
            gridLayout.SnapPointsType = SnapPointsType.Mandatory;

            carousel.ItemsLayout = gridLayout;

            CarouselItemsSource carouselItems = new CarouselItemsSource();
            ObservableCollection<ItemsSource> itemsSource = carouselItems.AllItems();

            itemsSourceCount = itemsSource.Count;

            Frame slideFrame = new Frame();
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

            slideFrame.Content = slideGrid;
            DataTemplate slideTemplate = new DataTemplate(() =>
            {
                return slideFrame;
            });

            carousel.ItemTemplate = slideTemplate;
            carousel.ItemsSource = itemsSource;

            return carousel;
        }
    }
}
