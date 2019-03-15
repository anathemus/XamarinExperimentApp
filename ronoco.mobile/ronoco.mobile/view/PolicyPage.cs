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
        // The following three methods set up the ability to bind the previous ListView's Index of the item tapped to an int
        public static readonly BindableProperty TappedIndexProperty = BindableProperty.Create(
            propertyName: nameof (TappedIndex),
            returnType: typeof (int),
            declaringType: typeof (PolicyPage),
            defaultValue: -1,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: HandleTappedIndexChanged
            );

        private static void HandleTappedIndexChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var page = (PolicyPage)bindable;
            page.TappedIndex = (int)newValue;
        }

        public int TappedIndex
        {
            get { return (int)GetValue(TappedIndexProperty); }
            set { SetValue(TappedIndexProperty, value); }
        }

        private PanCardView.CarouselView _carouselView;
        public PolicyPage GetPolicy()
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
            _carouselView.SelectedIndex = TappedIndex;
            Title = "Policy";
            Content = _carouselView;

            return this;
        }
        private View GetPolicyCard() => new PolicyView();
    }
}