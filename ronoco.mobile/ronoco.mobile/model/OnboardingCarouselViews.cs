using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class OnboardingCarouselViews : ContentView
    {
        ObservableCollection<View> CarouselViewCollection = new ObservableCollection<View>();
        public OnboardingCarouselViews()
        {
            var onboardingCarouselImages = new ObservableCollection<Image>();
            onboardingCarouselImages = OnboardingCarouselImageCollector.OnboardingImageCollector(onboardingCarouselImages);

            CarouselViewCollection.Equals =
            {
                new StackLayout
                {
                    Children =
                    {
                        onboardingCarouselImages.ElementAt(0),
                        new Label
                        {
                            Text = "Track your Coverages",
                            FontFamily = "SFUIDisplay-Medium",
                            FontSize = 26
                        },
                        new Label
                        {
                            Text = "All your policies are pulled together in one place so you don’t have to go digging around just " +
                            "to get the information you need when you need it.",
                            FontFamily = "SFUIText-Medium",
                            FontSize = 12
                        }
                    },
                },

                new StackLayout
                {
                    Children =
                    {
                        onboardingCarouselImages.ElementAt(1),
                        new Label
                        {
                            Text = "Get Solid Advice",
                            FontFamily = "SFUIDisplay-Medium",
                            FontSize = 26
                        },
                        new Label
                        {
                            Text = "No hold time on calls. No rearranging your schedule. No paperwork. No hassle.",
                            FontFamily = "SFUIText-Medium",
                            FontSize = 12
                        }
                    },
                },

                new StackLayout
                {
                    Children =
                    {
                        onboardingCarouselImages.ElementAt(2),
                        new Label
                        {
                            Text = "Find Savings Fast",
                            FontFamily = "SFUIDisplay-Medium",
                            FontSize = 26
                        },
                        new Label
                        {
                            Text = "Public data important for your rates is automatically incorporated. That helps us let " +
                            "you know when a better rate or coverage is available.",
                            FontFamily = "SFUIText-Medium",
                            FontSize = 12
                        }
                    },
                }
            };
        }

        //ObservableCollection<View> _carouselViewCollection;
        //public ObservableCollection<View> CarouselViewCollection
        //{
        //    set
        //    {
        //        _carouselViewCollection = value;
        //        //OnPropertyChanged("CarouselViewCollection");
        //    }
        //    get
        //    {
        //        return _carouselViewCollection;
        //    }
        //}

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}