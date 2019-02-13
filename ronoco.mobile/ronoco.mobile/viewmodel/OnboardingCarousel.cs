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
        private int index;
        private int itemsSourceCount = 0;
        public OnboardingCarousel(int index)
        {
            SetIndex(index);
            CarouselItemsSource carouselItems = new CarouselItemsSource();
            ObservableCollection<ItemsSource> itemsSource = carouselItems.AllItems();
            CarouselItemTemplate itemTemplate = new CarouselItemTemplate();

            itemTemplate.ImageSourceString = itemsSource.ElementAt(index).ImageSourceString;
            itemTemplate.HeaderText = itemsSource.ElementAt(index).HeaderText;
            itemTemplate.DescriptionText = itemsSource.ElementAt(index).DescriptionText;

            StackLayout layout = new StackLayout();
            itemsSourceCount = itemsSource.Count;
            layout = itemTemplate.CarouselTemplate(itemsSource[index], GetIndex());

            Content = layout;
        }

        public OnboardingCarousel()
        {
            CarouselItemsSource carouselItems = new CarouselItemsSource();
            ObservableCollection<ItemsSource> itemsSource = carouselItems.AllItems();
            CarouselItemTemplate itemTemplate = new CarouselItemTemplate();

            itemTemplate.ImageSourceString = itemsSource.ElementAt(index).ImageSourceString;
            itemTemplate.HeaderText = itemsSource.ElementAt(index).HeaderText;
            itemTemplate.DescriptionText = itemsSource.ElementAt(index).DescriptionText;

            RelativeLayout layout = new RelativeLayout();
            itemsSourceCount = itemsSource.Count;
            layout = itemTemplate.CarouselTemplate(itemsSource[index], GetIndex());

            Content = layout;
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public int GetItemsSourceCount()
        {
            return this.itemsSourceCount;
        }
    }
}