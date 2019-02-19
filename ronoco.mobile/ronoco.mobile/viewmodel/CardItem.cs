using ronoco.mobile.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class CardItem : ContentView
    {
        public CardItem()
        {
            // testing purposes
            Label number = new Label
            {
                TextColor = Color.Black,
                FontSize = 70,
                WidthRequest = 280,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold
            };
            number.SetBinding(Label.TextProperty, "Number");

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
                HorizontalTextAlignment = TextAlignment.Center
            };
            slideDescription.SetBinding(Label.TextProperty, "DescriptionText");

            ScrollView slideScroller = new ScrollView
            {
                Content = new StackLayout
                {
                    WidthRequest = 280,
                    Children =
                    {
                        number
                        //slideImage,
                        //slideHeader,
                        //slideDescription
                    }
                }
            };

            Content = slideScroller;
        }
    }
}
