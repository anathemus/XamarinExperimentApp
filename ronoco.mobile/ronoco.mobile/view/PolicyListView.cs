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
            List<Policy> policies = new List<Policy>
            {
                new Policy {
                PolicyName = "2005 Boston Whaler Outrage",
                CompanyName = "Safeco",
                PolicyType = PolicyType.Boat,
                PolicyNumber = "12M758811",
                PolicyActiveDate = DateTime.Parse("02/22/2019"),
                PolicyExpirationDate = DateTime.Parse("02/06/2020"),
                PolicyPremium = Decimal.Parse("789")
                }
            };

            //loop back through to grab string values
            foreach (var policy in policies)
            {
                policy.PolicyTypeString = policy.PolicyType.ToString();
                policy.PolicyActiveDateString = policy.PolicyActiveDate.ToShortDateString();
                policy.PolicyExpirationDateString = policy.PolicyExpirationDate.ToShortDateString();
                policy.PolicyPremiumString = policy.PolicyPremium.ToString();
            }

            ListView activePolicyListView = new ListView();
            activePolicyListView.RowHeight = 74;
            activePolicyListView.ItemsSource = policies;
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