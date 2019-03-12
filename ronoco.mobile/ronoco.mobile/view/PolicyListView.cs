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
    public class PolicyListView : TabbedPage
    {
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

            ListView previousPolicyListView = new ListView();
            ContentPage activePolicyListTab = new ContentPage();
            activePolicyListTab.Title = "Active";
            activePolicyListTab.Content = activePolicyListView;
            ContentPage previousPolicyListTab = new ContentPage();
            previousPolicyListTab.Title = "Previous";
            Children.Add(activePolicyListTab);
            Children.Add(previousPolicyListTab);
        }

        private void ActivePolicy_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PolicyPage page = new PolicyPage { TappedIndex = e.SelectedItemIndex };
            page = page.GetPolicy();
            // Navigation.PushAsync(page);
            App.Current.MainPage = page;
        }
    }
}