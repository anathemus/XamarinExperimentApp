using PanCardView.Controls;
using PanCardView.Controls.Styles;
using PanCardView;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using ronoco.mobile.viewmodel;
using ronoco.mobile.model;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ronoco.mobile.view
{
    public class Onboarding : ContentPage
    {
        private readonly PanCardView.CarouselView _carouselView;
        public Onboarding()
        {
            Padding = new Thickness(0);
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
                        },

                        UnselectedIndicatorStyle = new Style(typeof(Frame))
                        {
                            BasedOn = DefaultIndicatorItemStyles.DefaultUnselectedIndicatorItemStyle,
                            Setters =
                            {
                                new Setter { Property = BackgroundColorProperty, Value = Color.FromRgb(70, 120, 200)},
                                new Setter { Property = OpacityProperty, Value = 0.5 }
                            }
                        }
                    }
                }
            };
            _carouselView.SetBinding(CardsView.ItemsSourceProperty, nameof(OnboardingItemsSource.AllItems));
            Title = "Onboarding";

            Content = OnboardingGrid(_carouselView);

            BindingContext = new OnboardingItemsSource();
        }

        private View GetCardItem() => new CardItem();

        private Grid OnboardingGrid(PanCardView.CarouselView carouselView)
        {
            Grid grid = new Grid();
            OnboardingTemplate template = new OnboardingTemplate();
            template.signUpEmailButton.Pressed += SignUpEmailButton_Pressed;

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(352, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(32, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength((App.Current.MainPage.Height / 11.83333), GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength((App.Current.MainPage.Height / 11.83333), GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength((App.Current.MainPage.Height / 11.83333), GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(8, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.BackgroundColor = Color.White;

            grid.RowSpacing = 0;
            grid.ColumnSpacing = 0;

            // must use baseclass Grid to SetColumnSpan, cannot use instantiated object
            grid.Children.Add(carouselView, 0, 0);
            Grid.SetColumnSpan(carouselView, 3);
            grid.Children.Add(template.signInButton, 0, 6);
            Grid.SetColumnSpan(template.signInButton, 3);
            grid.Children.Add(template.signUpEmailButton, 0, 4);
            Grid.SetColumnSpan(template.signUpEmailButton, 3);
            grid.Children.Add(template.signUpFacebookButton, 0, 2);
            grid.Children.Add(template.signUpGoogleButton, 2, 2);

            return grid;
        }

        private void SignUpEmailButton_Pressed(object sender, EventArgs e)
        {
            RonocoToolbar toolbar = new RonocoToolbar().MakeRonocoToolbar(Color.White);
            RonocoToolbarButton toolbarButton = new RonocoToolbarButton().GetNavToolbarButton(ronoco.mobile.viewmodel.Icon.IconType.Solid, "\uf060", Color.FromRgb(80, 80, 100));
            toolbarButton.HorizontalOptions = LayoutOptions.Start;
            toolbarButton.BackgroundColor = Color.White;
            toolbarButton.Clicked += BackButton_Tapped;

            toolbar = toolbar.AddToolbarButton(toolbar, toolbarButton);

            SignUpEmail emailPage = new SignUpEmail();

            ContentPage emailContent = new RonocoNavigationPage().CreateRonocoWithToolbar(emailPage, toolbar, RonocoToolbar.ToolbarType.Top);
            NavigationPage.SetHasNavigationBar(emailContent, false);

            Navigation.PushAsync(emailContent);
        }

        private void BackButton_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
    
