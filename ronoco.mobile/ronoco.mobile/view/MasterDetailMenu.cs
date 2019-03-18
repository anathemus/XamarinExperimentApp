using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.model;
using ronoco.mobile.tests;

namespace ronoco.mobile.view
{
    public class MasterDetailMenu : ContentPage
    {
        public ListView ListView { get { return listView; } }

        ListView listView;
        public MasterDetailMenu()
        {
            DemoAccount demoAccount = new DemoAccount();
            Account account = demoAccount.GetAccount();
            List<model.MenuItem> menuItems = new List<model.MenuItem>();
            menuItems.Add(new model.MenuItem
            {
                MenuIcon = new viewmodel.Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf3ed" , Color.FromRgb(80, 80, 100)),
                MenuPageName = "Policies",
                TargetPageType = typeof(PolicyListView)
            });
            menuItems.Add(new model.MenuItem
            {
                MenuIcon = new viewmodel.Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf550", Color.FromRgb(80, 80, 100)),
                MenuPageName = "Assets",
                TargetPageType = typeof(AssetsPage)
            });
            menuItems.Add(new model.MenuItem
            {
                MenuIcon = new viewmodel.Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf3fd", Color.FromRgb(80, 80, 100)),
                MenuPageName = "Score",
                TargetPageType = typeof(ScorePage)
            });
            menuItems.Add(new model.MenuItem
            {
                MenuIcon = new viewmodel.Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf470", Color.FromRgb(80, 80, 100)),
                MenuPageName = "Advice",
                TargetPageType = typeof(AdvicePage)
            });

            constants.RonocoGrid gridInstance = new constants.RonocoGrid();
            Grid masterGrid = gridInstance.RonocoMenuGrid;

            FileImageSource imageSource = new FileImageSource { File = "avatarJenniferGenacco.png" };

            Image profileImage = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source = imageSource
            };

            Label profileLabel = new Label
            {
                FontFamily = "SFUIText-Semibold",
                FontSize = 16,
                TextColor = Color.White,
                Text = account.GetFirstname() + " " + account.GetLastname()                
            };

            Label profileDetails = new Label
            {
                FontFamily = "SFUIText-Medium",
                FontSize = 11,
                TextColor =Color.White,
                Text = account.GetEmail()
            };

            StackLayout profileLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.FromRgb(70, 120, 200),
                Padding = new Thickness(16, 0),
                Children = { profileImage }
            };

            BoxView whiteBackgroundBox = new BoxView
            {
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            BoxView greyBackgroudBox = new BoxView
            {
                BackgroundColor = Color.FromRgb(239, 239, 241),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            masterGrid.RowSpacing = 0;
            masterGrid.ColumnSpacing = 0;
            masterGrid.Children.Add(profileLayout, 0, 0);
            Grid.SetRowSpan(profileLayout, 1);
            Grid.SetColumnSpan(profileLayout, 4);
            masterGrid.Children.Add(whiteBackgroundBox, 0, 1);
            Grid.SetRowSpan(whiteBackgroundBox, 6);
            Grid.SetColumnSpan(whiteBackgroundBox, 4);
            masterGrid.Children.Add(greyBackgroudBox, 0, 7);
            Grid.SetRowSpan(greyBackgroudBox, 5);
            Grid.SetColumnSpan(greyBackgroudBox, 4);

            Icon = (new viewmodel.Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf0c9", Color.White).Source as FileImageSource);

            

            Title = "Ronoco";
            Content = masterGrid;
        }
    }
}
