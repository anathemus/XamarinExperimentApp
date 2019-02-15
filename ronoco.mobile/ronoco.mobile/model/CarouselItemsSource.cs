﻿using ronoco.mobile.viewmodel;
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
                ImageFile = ImageSource.FromFile("trackYourCoverages.jpg"),
                HeaderText = "Track your Coverages",
                DescriptionText = "All your policies are pulled together in one\n place so you don’t " +
                        "have to go digging\n around just to get the information you need\n when you need it.",
                ButtonIndex = new BoxView { TabIndex = 0 }
            });
            items.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("getSolidAdvice.jpg"),
                HeaderText = "Get Solid Advice",
                DescriptionText = "No hold time on calls.\n No rearranging your schedule.\n No paperwork.\n No hassle.",
                ButtonIndex = new BoxView { TabIndex = 1 }
            });
            items.Add(new ItemsSource
            {
                ImageFile = ImageSource.FromFile("findSavingsFast.jpg"),
                HeaderText = "Find Savings Fast",
                DescriptionText = "Public data important for your rates\n is automatically incorporated. " +
                        "That helps\n us let you know when a better rate\n or coverage is available.",
                ButtonIndex = new BoxView { TabIndex = 2 }
            });

            return items;
        }
        
    }

    public class ItemsSource
    {
        public ImageSource ImageFile { get; set; }
        public string HeaderText { get; set; }
        public string DescriptionText { get; set; }
        public BoxView ButtonIndex { get; set; }
    }
}
