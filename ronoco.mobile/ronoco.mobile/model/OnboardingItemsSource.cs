using ronoco.mobile.viewmodel;
using System;
using System.Collections;
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
            AllItems = new List<ItemsSource>();
            AllItems.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("trackYourCoverages.jpg"),
                HeaderText = "Track your Coverages",
                DescriptionText = "All your policies are pulled together in one\n place so you don’t " +
                            "have to go digging\n around just to get the information you need\n when you need it."
            });
            AllItems.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("getSolidAdvice.jpg"),
                HeaderText = "Get Solid Advice",
                DescriptionText = "No hold time on calls.\n No rearranging your schedule.\n No paperwork.\n No hassle."
            });
            AllItems.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("findSavingsFast.jpg"),
                HeaderText = "Find Savings Fast",
                DescriptionText = "Public data important for your rates\n is automatically incorporated. " +
                            "That helps\n us let you know when a better rate\n or coverage is available."
            });

        }
            public List<ItemsSource> AllItems { get; }        
    }

    public class ItemsSource
    {
        public ImageSource ImageFile { get; set; }
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
    }
}
