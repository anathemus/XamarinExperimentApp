using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class RonocoNavigationPage : NavigationPage
    {
        public RonocoNavigationPage MakeWhiteBackButtonNavPage(ContentPage page)
        {
            RonocoNavigationPage navigationPage = new RonocoNavigationPage();
            navigationPage.SetValue(HasNavigationBarProperty, "false");
            ObservableCollection<RonocoToolbarButton> buttons = new ObservableCollection<RonocoToolbarButton>
            {
                    new RonocoToolbarButton().GetNavToolbarButton(ronoco.mobile.viewmodel.Icon.IconType.Solid, "\uf060", Color.FromRgb(80, 80, 100))
            };

            RonocoToolbar toolbar = new RonocoToolbar
            {
                ToolbarButtons = buttons
            }.MakeRonocoToolbar(Color.White);

            // toolbar.ToolbarButtons = buttons;

            Grid grid = new Grid
            {
                Padding = new Thickness(0),
                RowDefinitions =
                    {
                        new RowDefinition {Height = new GridLength(64, GridUnitType.Absolute)},
                        new RowDefinition {Height = new GridLength(1, GridUnitType.Star)}
                    },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                }
            };
            grid.Children.Add(toolbar, 0, 0);

            page = new ContentPage
            {
                Content = grid
            };

            navigationPage.PushAsync(page);

            return navigationPage;
        }
    }
}