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
        private int index;
        public Onboarding()
        {
            OnboardingCarouselPage carousel = new OnboardingCarouselPage();
            this.index = carousel.CurrentPage.TabIndex;
            OnboardingTemplate template = new OnboardingTemplate();
            int itemsSource = new OnboardingItemsSource().AllItems().Count();
            template.SetSlideIndex(index);
            template.SetItemsSourceCount(itemsSource);

            Grid onboardingGrid = new Grid();
            onboardingGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            onboardingGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            onboardingGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            // onboardingGrid.Children.Add(carousel.OnboardingCarousel(), 0, 0);
            onboardingGrid.Children.Add(template, 0, 0);

            Content = onboardingGrid;
        }
    }
}