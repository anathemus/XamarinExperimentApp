using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ronoco.mobile.view
{
    public class PolicyListView : TabbedPage
    {
        public PolicyListView()
        {
            ListView activePolicyListView = new ListView();
            ListView previousPolicyListView = new ListView();
            ContentPage activePolicyListTab = new ContentPage();
            activePolicyListTab.Title = "Active";
            ContentPage previousPolicyListTab = new ContentPage();
            previousPolicyListTab.Title = "Previous";
            Children.Add(activePolicyListTab);
            Children.Add(previousPolicyListTab);
        }
    }
}