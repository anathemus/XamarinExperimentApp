using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ronoco.mobile.model;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ronoco.mobile.view
{
	public class Onboarding : ContentPage
	{
        public Onboarding()
        {
            ObservableCollection<Image> collection = new ObservableCollection<Image>();
            OnboardingCarouselImageCollector.OnboardingImageCollector(collection);
            var onboardingPageOne = new OnboardingCarouselContent();
            var onboardingPageTwo = new OnboardingCarouselContent();
            var onboardingPageThree = new OnboardingCarouselContent();

            onboardingPageOne.Title = Constants.ONBOARDING_CAROUSEL_ONE_HEADER_TXT;
            onboardingPageOne.Description = Constants.ONBOARDING_CAROUSEL_ONE_DESCRIPTION_TXT;
            onboardingPageOne.ImageSource = collection.ElementAt(0);

            onboardingPageOne.Title = Constants.ONBOARDING_CAROUSEL_TWO_HEADER_TXT;
            onboardingPageOne.Description = Constants.ONBOARDING_CAROUSEL_TWO_DESCRIPTION_TXT;
            onboardingPageOne.ImageSource = collection.ElementAt(1);

            onboardingPageOne.Title = Constants.ONBOARDING_CAROUSEL_THREE_HEADER_TXT;
            onboardingPageOne.Description = Constants.ONBOARDING_CAROUSEL_THREE_DESCRIPTION_TXT;
            onboardingPageOne.ImageSource = collection.ElementAt(2);

            var pages = new ObservableCollection<OnboardingCarouselContent>();
            pages.Add(onboardingPageOne);
            pages.Add(onboardingPageTwo);
            pages.Add(onboardingPageThree);

            var carouselView = new OnboardingCarousel(pages);

            Content = new StackLayout
            {
                Children =
                {
                    carouselView
                }
            };
        }
	}
}