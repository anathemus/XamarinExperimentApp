using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    class CarouselItemTemplate : DataTemplate
    {
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
        public ImageSource ImageSourceString { get; set; }

        public DataTemplate CarouselLayout(CarouselItemTemplate pageItems)
        {
            DataTemplate dataTemplate = new DataTemplate
            (() =>
            {
                Image image = new Image();
                image.Source.SetBinding(Image.SourceProperty, "ImageSourceString");

                Label header = new Label();
                header.FontFamily = "SFUIDisplay-Medium";
                header.FontSize = 26;
                header.SetBinding(Label.TextProperty, "HeaderText");


                Label description = new Label();
                description.FontFamily = "SFUIText-Medium";
                description.FontSize = 12;
                description.SetBinding(Label.TextProperty, "DescriptionText");

                return new ContentPage
                {
                Content =

                    new StackLayout
                    {
                        Children =
                        {
                            image,
                            header,
                            description
                        }
                    }
                };
            });
            return dataTemplate;
        }
    }
}
