using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Security.Cryptography;
using System.Text;
using ronoco.mobile.model;

namespace ronoco.mobile.viewmodel
{
    public class OnboardingDataTemplate
    {
        public OnboardingDataTemplate()
        {
            OnboardingCarouselContent templateContent = new OnboardingCarouselContent();
            //Create that new DataTemplate
            var template = new DataTemplate(() =>
            {
                //We chose an AbsoluteLayout for this because it is the 
                //most flexble layout in my opinion.
                var page1 = new RelativeLayout();
                page1.VerticalOptions = LayoutOptions.StartAndExpand;
                page1.HeightRequest = 352;

                page1.Children.Add(templateContent.ImageSource);
                page1.Children.Add(templateContent.Title);
                page1.Children.Add(templateContent.Description);

                RelativeLayout.SetBoundsConstraint(templateContent.ImageSource, templateContent.ImageSource.Source.);

                return page1;
            });
        }
    }
}
