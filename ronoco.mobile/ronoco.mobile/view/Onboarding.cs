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
	public class Onboarding : ContentView
	{
        public ObservableCollection<ContentView> Onboarding()
        {
            CarouselItemsSource itemsSource = new CarouselItemsSource();
            CarouselItemTemplate itemTemplate = new CarouselItemTemplate();

            ContentView view1 = new ContentView
            {
               
            };

        }
	}
}