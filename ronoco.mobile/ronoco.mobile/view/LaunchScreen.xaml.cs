using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ronoco.mobile.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LaunchScreen : ContentPage
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
			InitializeComponent ();
		}
	}
}