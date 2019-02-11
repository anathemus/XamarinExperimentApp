using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    class CarouselItemsSource
    {
        public string ImageSourceString { get; set; }

        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }

        public static IList<CarouselItemsSource> All { get; set; }
        public CarouselItemsSource()
        {
            All = new ObservableCollection<CarouselItemsSource>
               {
                   new CarouselItemsSource
                   {
                       ImageSourceString = "trackYourCoverages.jpg",
                       HeaderText = "Track your Coverages",
                       DescriptionText = "All your policies are pulled together in one place so you don’t " +
                       "have to go digging around just to get the information you need."
                   },

                   new CarouselItemsSource
                   {
                       ImageSourceString = "getSolidAdvice.jpg",
                       HeaderText = "Get Solid Advice",
                       DescriptionText = "No hold time on calls. No rearranging your schedule. No paperwork. No hassle."
                   },

                   new CarouselItemsSource
                   {
                       ImageSourceString = "findSavingsFast.jpg",
                       HeaderText = "Find Savings Fast",
                       DescriptionText = "Public data important for your rates is automatically incorporated. " +
                       "That helps us let you know when a better rate or coverage is available."
                   }
               };
        }
    }
}
