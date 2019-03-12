using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class RonocoNavigationPage : ContentPage
    {
        public RonocoToolbar TopNavBar { get; set; }
        public RonocoToolbar BottomToolBar { get; set; }
        public RonocoNavigationPage() { }
        public RonocoNavigationPage(ContentPage page)
        {
            // use NavigationPage.SetHasNavigationBar(Page, bool) to hide Native NavigationBar (bool must be false)
            NavigationPage.SetHasNavigationBar(page, false);
            Navigation.PushAsync(page);
        }

        public ContentPage CreateRonocoWithToolbar(ContentPage page, RonocoToolbar toolbar, RonocoToolbar.ToolbarType type)
        {
            // use NavigationPage.SetHasNavigationBar(Page, bool) to hide Native NavigationBar (bool must be false)
            NavigationPage.SetHasNavigationBar(page, false);

            Grid grid = new Grid
            {
                Padding = new Thickness(0),
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                }
            };

            switch (type)
            {
                case RonocoToolbar.ToolbarType.Top:
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(64, GridUnitType.Absolute) });
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    grid.Children.Add(toolbar, 0, 0);
                    grid.Children.Add(page.Content, 0, 1);
                    TopNavBar = toolbar;
                    break;
                case RonocoToolbar.ToolbarType.Bottom:
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) });
                    grid.Children.Add(page.Content, 0, 1);
                    grid.Children.Add(toolbar, 0, 0);
                    BottomToolBar = toolbar;
                    break;
                default:
                    break;
            }

            ContentPage content = new ContentPage
            {
                Content = grid
            };

            // use NavigationPage.SetHasNavigationBar(Page, bool) to hide Native NavigationBar (bool must be false)
            // NavigationPage.SetHasNavigationBar(content, false);

            return content;
        }

        public ContentPage CreateRonocoWithToolbar(ContentPage page, RonocoToolbar topToolbar, RonocoToolbar bottomToolbar)
        {
            // use NavigationPage.SetHasNavigationBar(Page, bool) to hide Native NavigationBar (bool must be false)
            NavigationPage.SetHasNavigationBar(page, false);

            Grid grid = new Grid
            {
                Padding = new Thickness(0),
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                },
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(64, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) }
                }
            };

            grid.Children.Add(topToolbar, 0, 0);
            grid.Children.Add(page.Content, 0, 1);
            grid.Children.Add(bottomToolbar, 0, 2);

            TopNavBar = topToolbar;
            BottomToolBar = bottomToolbar;

            ContentPage content = new ContentPage
            {
                Content = grid
            };

            // use NavigationPage.SetHasNavigationBar(Page, bool) to hide Native NavigationBar (bool must be false)
            NavigationPage.SetHasNavigationBar(content, false);

            return content;
        }
        //public RonocoNavigationPage MakeWhiteBackButtonNavPage(ContentPage page)
        //{
        //    RonocoNavigationPage navigationPage = new RonocoNavigationPage();
        //    ObservableCollection<RonocoToolbarButton> buttons = new ObservableCollection<RonocoToolbarButton>
        //    {
        //            new RonocoToolbarButton().GetNavToolbarButton(ronoco.mobile.viewmodel.Icon.IconType.Solid, "\uf060", Color.FromRgb(80, 80, 100))
        //    };

        //    RonocoToolbar toolbar = new RonocoToolbar
        //    {
        //        ToolbarButtons = buttons
        //    }.MakeRonocoToolbar(Color.White);

        //    // toolbar.ToolbarButtons = buttons;

        //    Grid grid = new Grid
        //    {
        //        Padding = new Thickness(0),
        //        RowDefinitions =
        //            {
        //                new RowDefinition {Height = new GridLength(64, GridUnitType.Absolute)},
        //                new RowDefinition {Height = new GridLength(1, GridUnitType.Star)}
        //            },
        //        ColumnDefinitions =
        //        {
        //            new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
        //        }
        //    };
        //    grid.Children.Add(toolbar, 0, 0);
        //    grid.Children.Add(page.Content, 0, 1);

        //    ContentPage content = new ContentPage
        //    {
        //        Content = grid
        //    };

        //    // use NavigationPage.SetHasNavigationBar(Page, bool) to hide Native NavigationBar (bool must be false)
        //    NavigationPage.SetHasNavigationBar(content, false);

        //    navigationPage.PushAsync(content);

        //    return navigationPage;
        //}
    }
}