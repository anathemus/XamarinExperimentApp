using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ronoco.mobile.model;
using ronoco.mobile.viewmodel;
using ronoco.mobile.tests;
using Xamarin.Forms;
using System.Diagnostics;

namespace ronoco.mobile.view
{
    public class PolicyListView : ContentPage
    {
        public ListView ActiveView { get; set; }
        public ListView PreviousView { get; set; }
        public BoxView ActiveTabLine { get; set; }
        public PolicyListView()
        {
            // instantiate the Account first.
            Account account = new Account();
            DemoAccount demoAccount = new DemoAccount();
            account = demoAccount.GetAccount();

            // grab the List of Policies from the Account
            List<Policy> policies = account.GetPolicies();

            ListView activePolicyListView = new ListView();
            activePolicyListView.RowHeight = 74;
            activePolicyListView.ItemsSource = policies;
            activePolicyListView.ItemTemplate = new DataTemplate(typeof(PolicyCell));
            activePolicyListView.ItemSelected += ActivePolicy_ItemSelected;
            ActiveView = activePolicyListView;

            // previousPolicyListView not yet implemented.
            ListView previousPolicyListView = new ListView();
            previousPolicyListView.IsVisible = false;
            PreviousView = previousPolicyListView;

            //Icon menuIcon = new Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf0c9", Color.White);
            //TapGestureRecognizer menuTap = new TapGestureRecognizer();

            //RonocoToolbarButton menuButton = new RonocoToolbarButton
            //{
            //    HorizontalOptions = LayoutOptions.StartAndExpand,
            //    VerticalOptions = LayoutOptions.Center,
            //    Children = { menuIcon }
            //};
            //menuButton.GestureRecognizers.Add(menuTap);
            //(menuButton.GestureRecognizers.ElementAt(0) as TapGestureRecognizer).Tapped += MenuButton_Clicked;

            Label titleLabel = new Label
            {
                FontFamily = "SFUIText-Semibold",
                FontSize = 16,
                TextColor = Color.White,
                Text = "Policies",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            Icon plusIcon = new Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf067", Color.White);
            TapGestureRecognizer plusTap = new TapGestureRecognizer();

            RonocoToolbarButton plusMiniMenuButton = new RonocoToolbarButton
            {
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Children = { plusIcon }
            };
            plusMiniMenuButton.GestureRecognizers.Add(plusTap);
            (plusMiniMenuButton.GestureRecognizers.ElementAt(0) as TapGestureRecognizer).Tapped += PlusMiniMenuButton_Clicked;

            RonocoToolbar listToolbar = new RonocoToolbar().MakeRonocoToolbar(Color.FromRgb(70, 120, 200));
            listToolbar.Padding = new Thickness(0, 0, 10, 0);
            // listToolbar.Children.Add(menuButton);
            listToolbar.Children.Add(titleLabel);
            listToolbar.Children.Add(plusMiniMenuButton);

            // sets listToolbar as NavigationBar
            NavigationPage.SetTitleView(this, listToolbar);

            RonocoToolbar bottomToolbar = new RonocoToolbar().MakeBottomRonocoToolbar(Color.FromRgb(202, 202, 208), Color.FromRgb(80, 80, 100));

            StackLayout layout = new StackLayout();
            layout.Orientation = StackOrientation.Horizontal;
            Grid tabbedNavListGrid = constants.RonocoGrid.RonocoBottomToolbarTabsGrid;

            // Tab Buttons defined here to get dimensions of instantiated grid and pass the Button object to Grid.Children
            RonocoToolbarButton activeButton = new RonocoToolbarButton().GetTabToolbarButton("Active", Color.White);
            activeButton.BackgroundColor = Color.FromRgb(70, 120, 200);
            activeButton.Padding = new Thickness(0, 8);
            (activeButton.GestureRecognizers.ElementAt(0) as TapGestureRecognizer).Tapped += ActiveButton_Clicked;

            RonocoToolbarButton previousButton = new RonocoToolbarButton().GetTabToolbarButton("Previous", Color.White);
            previousButton.BackgroundColor = Color.FromRgb(70, 120, 200);
            previousButton.Padding = new Thickness(0, 8);
            (previousButton.GestureRecognizers.ElementAt(0) as TapGestureRecognizer).Tapped += PreviousButton_Clicked;

            BoxView activeTabLine = new BoxView
            {
                BackgroundColor = Color.FromRgb(195, 215, 245),
                HeightRequest = 4,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End
            };

            ActiveTabLine = activeTabLine;

            // add a BoxView first to hide Button corners
            BoxView box = new BoxView
            {
                BackgroundColor = Color.FromRgb(70, 120, 200),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            tabbedNavListGrid.Children.Add(box, 0, 0);
            Grid.SetColumnSpan(box, 2);
            tabbedNavListGrid.Children.Add(activeButton, 0, 0);
            tabbedNavListGrid.Children.Add(previousButton, 1, 0);
            tabbedNavListGrid.Children.Add(activeTabLine, 0, 0);

            // add both/all listviews into same Grid Column, Row, ColumnSpan, etc.
            // IMPORTANT!!! Make sure ONLY ONE ListView IsVisible at a time.
            tabbedNavListGrid.Children.Add(activePolicyListView, 0, 1);
            Grid.SetColumnSpan(activePolicyListView, 2);
            tabbedNavListGrid.Children.Add(previousPolicyListView, 0, 1);
            Grid.SetColumnSpan(previousPolicyListView, 2);

            tabbedNavListGrid.Children.Add(bottomToolbar, 0, 2);
            Grid.SetColumnSpan(bottomToolbar, 2);

            Content = tabbedNavListGrid;
        }

        private void PlusMiniMenuButton_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Under Construction!");
        }

        //private void MenuButton_Clicked(object sender, EventArgs e)
        //{
        //    Debug.WriteLine("Under Construction!");
        //}

        private void PreviousButton_Clicked(object sender, EventArgs e)
        {
            ActiveView.IsVisible = false;
            PreviousView.IsVisible = true;
            ActiveTabLine.TranslateTo(this.TranslationX + (App.Current.MainPage.Width / 2), this.TranslationY);
        }

        private void ActiveButton_Clicked(object sender, EventArgs e)
        {
            PreviousView.IsVisible = false;
            ActiveView.IsVisible = true;
            ActiveTabLine.TranslateTo(this.TranslationX, this.TranslationY);
        }

        private void ActivePolicy_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PolicyPage page = new PolicyPage { TappedIndex = e.SelectedItemIndex };
            page = page.GetPolicy();

            Navigation.PushAsync(page);
        }
    }
}