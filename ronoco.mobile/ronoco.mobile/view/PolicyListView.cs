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
            activePolicyListView.ItemsSource = new DefaultAccount().Policies;
            activePolicyListView.ItemTemplate = new DataTemplate (() =>
            { var cell = new PolicyCell();
                cell.SetBinding(PolicyCell.TypeLabelProperty, "PolicyType");
                cell.SetBinding(PolicyCell.PremiumLabelProperty, "PolicyPremium");
                cell.SetBinding(PolicyCell.CompanyLabelProperty, "CompanyName");
                cell.SetBinding(PolicyCell.ExpirationLabelProperty, "PolicyExpirationDate");
                cell.SetBinding(PolicyCell.ExpirationBarProperty, "PolicyExpirationDateFractionDouble");

                return cell;
            });
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