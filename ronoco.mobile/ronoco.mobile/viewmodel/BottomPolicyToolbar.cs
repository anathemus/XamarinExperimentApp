using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class BottomPolicyToolbar : BoxView
    {
        public BottomPolicyToolbar()
        {
            Color = Color.FromRgb(202, 202, 208);
            BottomToolbarButton toolbarButton = new BottomToolbarButton();

            StackLayout policyButton = toolbarButton.GetBottomToolbarButton(BottomToolbarButton.ButtonType.Policies);

            StackLayout bottomToolbarLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HeightRequest = 48,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = { policyButton }
            };
        }
    }
}