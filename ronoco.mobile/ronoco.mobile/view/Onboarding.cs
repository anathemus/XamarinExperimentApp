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
            carousel = new OnboardingCarousel();

            Content = carousel;
        }
    }
}