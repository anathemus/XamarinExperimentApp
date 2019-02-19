using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ronoco.mobile.model;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class OnboardingCarouselView : CarouselPage
    {
        public CarouselPage OnboardingCarousel()
        {
            CarouselPage carouselPage = new CarouselPage();
            carouselPage.ItemsSource = new OnboardingItemsSource().AllItems;
            // carouselPage.ItemTemplate = new OnboardingSlides();
            return carouselPage;
        }
    }
}