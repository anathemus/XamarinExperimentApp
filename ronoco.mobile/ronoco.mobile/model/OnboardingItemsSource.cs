using ronoco.mobile.viewmodel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class OnboardingItemsSource
    {
        public OnboardingItemsSource()
        {
            ObservableCollection<ItemsSource> itemsSource = new ObservableCollection<ItemsSource>();
            itemsSource.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("trackYourCoverages.jpg"),
                HeaderText = "Track your Coverages",
                DescriptionText = "All your policies are pulled together in one\n place so you don’t " +
                            "have to go digging\n around just to get the information you need\n when you need it."
            });
            itemsSource.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("getSolidAdvice.jpg"),
                HeaderText = "Get Solid Advice",
                DescriptionText = "No hold time on calls.\n No rearranging your schedule.\n No paperwork.\n No hassle."
            });
            itemsSource.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("findSavingsFast.jpg"),
                HeaderText = "Find Savings Fast",
                DescriptionText = "Public data important for your rates\n is automatically incorporated. " +
                            "That helps\n us let you know when a better rate\n or coverage is available."
            });

            AllItems = new ObservableCollection<object>(Enumerable.Range(1, 3).Select(i => new { Number = i }).ToArray());

            // = new ObservableCollection<object>(Enumerable.OfType<ItemsSource>(itemsSource));
            //{
            //    new ItemsSource
            //    {
            //        ImageFile = ImageSource.FromFile("trackYourCoverages.jpg"),
            //        HeaderText = "Track your Coverages",
            //        DescriptionText = "All your policies are pulled together in one\n place so you don’t " +
            //                "have to go digging\n around just to get the information you need\n when you need it."
            //    },
            //    new ItemsSource
            //    {
            //        ImageFile = ImageSource.FromFile("getSolidAdvice.jpg"),
            //        HeaderText = "Get Solid Advice",
            //        DescriptionText = "No hold time on calls.\n No rearranging your schedule.\n No paperwork.\n No hassle."
            //    },
            //    new ItemsSource
            //      {
            //        ImageFile = ImageSource.FromFile("findSavingsFast.jpg"),
            //        HeaderText = "Find Savings Fast",
            //        DescriptionText = "Public data important for your rates\n is automatically incorporated. " +
            //                "That helps\n us let you know when a better rate\n or coverage is available."
            //      }
            //};
        }
            public ObservableCollection<object> AllItems { get; }
        
    }

    public class ItemsSource
    {
        public ImageSource ImageFile { get; set; }
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
    }
}
