using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class CarouselItemsSource
    {
        public ObservableCollection<ItemsSource> AllItems()
        {
            ObservableCollection<ItemsSource> items = new ObservableCollection<ItemsSource>();
            items.Add(new ItemsSource
            {
                ImageSourceString = "trackYourCoverages.jpg",
                HeaderText = "Track your Coverages",
                DescriptionText = "All your policies are pulled together in one place so you don’t " +
                        "have to go digging around just to get the information you need."
            });
            items.Add(new ItemsSource
            {
                ImageSourceString = "getSolidAdvice.jpg",
                HeaderText = "Get Solid Advice",
                DescriptionText = "No hold time on calls. No rearranging your schedule. No paperwork. No hassle."
            });
            items.Add(new ItemsSource
            {
                ImageSourceString = "findSavingsFast.jpg",
                HeaderText = "Find Savings Fast",
                DescriptionText = "Public data important for your rates is automatically incorporated. " +
                        "That helps us let you know when a better rate or coverage is available."
            });

            return items;
        }
        
    }

    public class ItemsSource
    {
        public string ImageSourceString { get; set; }
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
    }
}
