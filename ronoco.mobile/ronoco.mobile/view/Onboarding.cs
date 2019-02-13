using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ronoco.mobile.model;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using ronoco.mobile.viewmodel;
using System.Diagnostics;

namespace ronoco.mobile.view
{
	public class Onboarding : ContentPage
	{
        
        private OnboardingCarousel carousel;
        private int index;
        public Onboarding(int index, OnboardingCarousel carousel)
        {
            this.index = index;
            this.carousel = carousel;
            carousel = new OnboardingCarousel(index);
            SwipeReader swipeReader = new SwipeReader { Content = carousel };
            swipeReader.Swipe += (sender, e) => OnSwiped(sender, e);

            Content = swipeReader;
        }


        public void OnSwiped(object sender, SwipedEventArgs e)
        {
            //index = carousel.GetIndex();

            switch (e.Direction)
            {
                case SwipeDirection.Right:
                    if (index > 0)
                    {
                        carousel.SetIndex(index--);
                    }
                    else
                    {
                        index = carousel.GetItemsSourceCount() - 1;
                        carousel.SetIndex(index);
                    }
                    App.Current.MainPage = new Onboarding(index, carousel);
                    break;
                case SwipeDirection.Left:
                    if (index < carousel.GetItemsSourceCount() - 1)
                    {
                        carousel.SetIndex(index++);
                    }
                    else
                    {
                        carousel.SetIndex(index = 0);
                    }
                    App.Current.MainPage = new Onboarding(index, carousel);
                    break;
                case SwipeDirection.Up:
                    break;
                case SwipeDirection.Down:
                    break;
                default:
                    break;
            }
        }
    }
}