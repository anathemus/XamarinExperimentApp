using CarouselView.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.model;
using System.Timers;
using CarouselView.Controls.CarouselLayout;

namespace ronoco.mobile.view
{
	public class OnboardingCarousel : ContentView
	{

        public OnboardingCarousel ()
		{
            ObservableCollection<View> carouselViews = new ObservableCollection<View>();
            OnboardingCarouselViews carouselViewsObj = new OnboardingCarouselViews();
            carouselViews = carouselViewsObj.;

            CarouselLayout onboardingCarousel = new CarouselLayout();

            foreach (var item in carouselViews)
            {
                onboardingCarousel.ItemsSource.Add(item);
            }

            Content = new StackLayout
            {
                Children =
                {
                    onboardingCarousel
                }
            };
		}

    }
}