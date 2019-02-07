using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    class OnboardingCarouselImageCollector
    {


        public static ObservableCollection<Image> OnboardingImageCollector (ObservableCollection<Image> images)
        {
            Image imageOne = new Image();
            Image imageTwo = new Image();
            Image imageThree = new Image();

            imageOne.Source = ImageSource.FromFile("trackYourCoverages.jpg");
            imageTwo.Source = ImageSource.FromFile("getSolidAdvice.jpg");
            imageThree.Source = ImageSource.FromFile("findSavingsFast.jpg");

            images.Add(imageOne);
            images.Add(imageTwo);
            images.Add(imageThree);

            return images;
        }
    }
}
