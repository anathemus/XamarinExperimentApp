using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.view
{
	public class LaunchScreen : ContentPage
	{
		public LaunchScreen ()
		{
            Image launchScreenImage = new Image();
            launchScreenImage.Source = ImageSource.FromFile("launchscreenimg.png");
            StackLayout stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,

                Children =
                {
                    launchScreenImage
                }
            };
            Content = stackLayout;
        }
	}
}