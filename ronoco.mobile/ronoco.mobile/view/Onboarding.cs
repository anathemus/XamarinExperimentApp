using PanCardView.Controls;
using PanCardView.Controls.Styles;
using PanCardView;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using ronoco.mobile.viewmodel;
using System.Diagnostics;

namespace ronoco.mobile.view
{
    public class Onboarding : ContentPage
    {
        private readonly PanCardView.CarouselView _carouselView;
        public Onboarding()
        {
            _carouselView = new PanCardView.CarouselView
            {
                ItemTemplate = new DataTemplate(GetCardItem),
                Children =
                {
                    new IndicatorsControl
                    {
                        SelectedIndicatorStyle = new Style(typeof(Frame))
                        {
                            BasedOn = DefaultIndicatorItemStyles.DefaultSelectedIndicatorItemStyle,
                            Setters =
                            {
                                new Setter { Property = BackgroundColorProperty, Value = Color.FromRgb(70,120,200)}
                            }
                        }
                    }
                }
            };
            _carouselView.SetBinding(CardsView.ItemsSourceProperty, nameof(OnboardingItemsSource.AllItems));
            Title = "Onboarding";

            Content = _carouselView;

            BindingContext = new OnboardingItemsSource();
        }

        private View GetCardItem() => new CardItem();
    }
}
    
