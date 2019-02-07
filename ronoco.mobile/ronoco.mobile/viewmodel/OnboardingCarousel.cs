using CarouselView.FormsPlugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.model;

namespace ronoco.mobile.view
{
	public class OnboardingCarousel : ContentView
	{
		public OnboardingCarousel ()
		{
            var onboardingCarousel = new CarouselViewControl();
            var onboardingCarouselImages = new ObservableCollection<Image>();

            onboardingCarouselImages = OnboardingCarouselImageCollector.OnboardingImageCollector(onboardingCarouselImages); 

			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}