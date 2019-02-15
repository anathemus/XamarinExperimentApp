using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ronoco.mobile.model;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class OnboardingCarousel : ContentView
    {
        private int itemsSourceCount = 0;

        public OnboardingCarousel()
        {
            CarouselItemsSource carouselItems = new CarouselItemsSource();
            ObservableCollection<ItemsSource> itemsSource = carouselItems.AllItems();
            OnboardingTemplate itemTemplate = new OnboardingTemplate();
            itemTemplate.SetItemsSourceCount(itemsSourceCount);

            Grid layout = new Grid();
            itemsSourceCount = itemsSource.Count;
            layout = itemTemplate.CarouselTemplate(itemsSourceCount);

            Content = layout;
        }

        public int GetItemsSourceCount()
        {
            return this.itemsSourceCount;
        }
    }
}