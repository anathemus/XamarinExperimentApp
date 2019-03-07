using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    class GreyRowLine : BoxView
    {
        public BoxView AddGreyRowLine()
        {
            //BoxView to create grey lines in main content rows
            BoxView greyRowLine = new BoxView
            {
                Color = Color.FromRgb(230, 230, 230),
                HeightRequest = 2,
                WidthRequest = 272,
                CornerRadius = 45,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            return greyRowLine;
        }
    }
}
