using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    class CarouselItemTemplate : RelativeLayout
    {
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
        public string ImageSourceString { get; set; }

        public RelativeLayout CarouselTemplate(ItemsSource pageItems)
        {
            // IMPORTANT NOTE! When creating attributes for template, it is not enough to instantiate!
            // The attributes must be initialized with at least one property to be recognized
            // otherwise they appear NULL
            Image image = new Image
            { Source = ImageSource.FromFile(ImageSourceString) };

            Label header = new Label
            {
                FontFamily = "SFUIDisplay-Medium",
                FontSize = 26,
                Text = HeaderText
            };

            Label description = new Label
            {
                FontFamily = "SFUIText-Medium",
                FontSize = 12,
                Text = DescriptionText
            };

            RelativeLayout carouselLayout = new RelativeLayout();
            carouselLayout.Children.Add(image, Constraint.RelativeToParent((parent) =>
            {
                return parent.Width * 0.1203125;
            }), Constraint.Constant(0));
            carouselLayout.Children.Add(header, Constraint.Constant(0), Constraint.RelativeToView(image, (parent, sibling) =>
            {
                return sibling.Height;
            }));
            carouselLayout.Children.Add(description, Constraint.Constant(0), Constraint.RelativeToView(header, (parent, sibling) =>
            {
                return sibling.Y + sibling.Height;
            }));

            return carouselLayout;
        }
    }
}
