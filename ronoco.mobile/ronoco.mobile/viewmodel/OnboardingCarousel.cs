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
        private int index = 0;
        private int itemsSourceCount = 0;
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
            layout = itemTemplate.CarouselTemplate(itemsSource[index]);

            SwipeGestureRecognizer leftSwipe = new SwipeGestureRecognizer { Direction = SwipeDirection.Left };
            leftSwipe.Swiped += OnSwiped;
            SwipeGestureRecognizer rightSwipe = new SwipeGestureRecognizer { Direction = SwipeDirection.Right };
            rightSwipe.Swiped += OnSwiped;

            this.GestureRecognizers.Add(leftSwipe);
            this.GestureRecognizers.Add(rightSwipe);
            this.Content = layout;
        }

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Right:
                    if (index < itemsSourceCount - 1)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                    break;
                case SwipeDirection.Left:
                    if (index > 0)
                    {
                        index--;
                    }
                    else
                    {
                        index = itemsSourceCount - 1;
                    }
                    break;
                case SwipeDirection.Up:
                    break;
                case SwipeDirection.Down:
                    break;
                default:
                    break;
            }
        }
    }
}