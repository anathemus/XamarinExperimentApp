using ronoco.mobile.viewmodel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class DefaultAccount
    {
        public DefaultAccount()
        {
            Account DemoAccount = new Account();
            DemoAccount.SetUsername("default");
            DemoAccount.SetMemberSince(DateTime.Parse("2/4/2019"));
        }

        public static List<Policy> GetDefaultPolicies()
        {
            List<Policy> Policies = new List<Policy>
            {
                new Policy {
                PolicyName = "2005 Boston Whaler Outrage",
                CompanyName = "Safeco",
                PolicyType = PolicyTypes.PolicyType.Boat,
                PolicyNumber = "12M758811",
                PolicyActiveDate = DateTime.Parse("2/22/2019"),
                PolicyExpirationDate = DateTime.Parse("2/6/2020"),
                PolicyPremium = Decimal.Parse("789")
                }
            };

            return Policies;
        }
    }
}
