using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.view
{
	public class Onboarding : ContentPage
	{
		public Onboarding ()
		{
            OnboardingCarousel carousel = new OnboardingCarousel();

            Content = new StackLayout
            {
                BackgroundColor = Color.White,

                Children =
                {
                    carousel
                }
            };
		}
	}
}