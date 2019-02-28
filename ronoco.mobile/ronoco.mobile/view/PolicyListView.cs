using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ronoco.mobile.model;
using ronoco.mobile.viewmodel;
using Xamarin.Forms;

namespace ronoco.mobile.view
{
    public class PolicyListView : TabbedPage
    {
        public PolicyListView()
        {
            ListView activePolicyListView = new ListView();
            List<Policy> policies = DefaultAccount.GetDefaultPolicies();
            activePolicyListView.ItemsSource = policies;

            activePolicyListView.SetBinding(PolicyCell.TypeLabelProperty, new Binding("PolicyType"));
            activePolicyListView.SetBinding(PolicyCell.CompanyLabelProperty, new Binding("CompanyName"));
            activePolicyListView.SetBinding(PolicyCell.ExpirationBarProperty, new Binding("PolicyExpirationDateFractionDouble"));
            activePolicyListView.SetBinding(PolicyCell.PremiumLabelProperty, new Binding("PolicyPremium"));
            activePolicyListView.SetBinding(PolicyCell.ExpirationLabelProperty, new Binding("PolicyExpirationDate"));
            activePolicyListView.ItemTemplate = new DataTemplate(typeof(PolicyCell));

            ListView previousPolicyListView = new ListView();
            ContentPage activePolicyListTab = new ContentPage();
            activePolicyListTab.Title = "Active";
            activePolicyListTab.Content = activePolicyListView;
            ContentPage previousPolicyListTab = new ContentPage();
            previousPolicyListTab.Title = "Previous";
            Children.Add(activePolicyListTab);
            Children.Add(previousPolicyListTab);
        }
    }
}