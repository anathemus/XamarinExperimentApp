using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class OnboardingCarouselContent
    {
        public Label Title { get; set; }
        public Label Description { get; set; }
        public Image ImageSource { get; set; }
        //public CarouselLayout CarouselViewCollection { get; set; };

        //public OnboardingCarouselView()
        //{
        //    var onboardingCarouselImages = new ObservableCollection<Image>();
        //    onboardingCarouselImages = OnboardingCarouselImageCollector.OnboardingImageCollector(onboardingCarouselImages);

        //    ObservableCollection < View > carouselItemsSource = new ObservableCollection<View>();
        //        new StackLayout
        //    {
        //        Children =
        //        {
        //            onboardingCarouselImages.ElementAt(0),
        //            Constants.ONBOARDING_CAROUSEL_ONE_HEADER_TXT,
        //            Constants.ONBOARDING_CAROUSEL_ONE_DESCRIPTION_TXT
        //        }
        //    });

        //    carouselItemsSource.Add(new StackLayout
        //    {
        //        Children =
        //        {
        //            onboardingCarouselImages.ElementAt(1),
        //            Constants.ONBOARDING_CAROUSEL_TWO_HEADER_TXT,
        //            Constants.ONBOARDING_CAROUSEL_TWO_DESCRIPTION_TXT
        //        }
        //    });

        //    carouselItemsSource.Add(new StackLayout
        //    {
        //        Children =
        //        {
        //            onboardingCarouselImages.ElementAt(2),
        //            Constants.ONBOARDING_CAROUSEL_THREE_HEADER_TXT,
        //            Constants.ONBOARDING_CAROUSEL_THREE_DESCRIPTION_TXT
        //        }
        //    });

        //    CarouselViewCollection.ItemsSource = carouselItemsSource;
        //}
    }
}