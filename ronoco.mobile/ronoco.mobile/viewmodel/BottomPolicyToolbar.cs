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

            StackLayout bottomToolbarLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,

            };
        }
    }
}