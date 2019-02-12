using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ronoco.mobile.model;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using ronoco.mobile.viewmodel;

namespace ronoco.mobile.view
{
	public class Onboarding : ContentPage
	{
        public Onboarding()
        {
            OnboardingCarousel carousel = new OnboardingCarousel();
            carousel.RaiseChild(carousel);
            Content = carousel.Content;
        }
	}
}