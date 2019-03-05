using PanCardView;
using ronoco.mobile.model;
using ronoco.mobile.tests;
using ronoco.mobile.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.view
{
    public class PolicyPage : ContentPage
    {
        private readonly PanCardView.CarouselView _carouselView;
        public PolicyPage()
        {
            _carouselView = new PanCardView.CarouselView
            {
                ItemTemplate = new DataTemplate(GetPolicyCard)
            };

            // instantiate account to access policies
            DemoAccount demoAccount = new DemoAccount();
            Account account = demoAccount.GetAccount();
            List<Policy> source = new List<Policy>();
            source = account.GetPolicies();
            _carouselView.ItemsSource = source;
            Title = "Policy";
            Content = _carouselView;
        }
        private View GetPolicyCard() => new PolicyView();
    }
}