using System;
using System.Collections.Generic;
using System.Text;
using ronoco.mobile.model;

namespace ronoco.mobile.tests
{
    class DemoAccount
    {
        public Account GetAccount()
        {
            Account account = new Account();

            account.SetUsername("demo");
            account.SetMemberSince(DateTime.Parse("03/04/2019"));

            List<Policy> policies = new List<Policy>
            {
                new Policy {
                    PolicyName = "2005 Boston Whaler\n250 Outrage",
                    // TODO: Put images in a list, then make the images "swipeable" without swiping to the next policy
                    PolicyImageFileString = "TwoThousandFiveBostonWhalerTwoFiftyOutrage.png",
                    CompanyName = "Safeco",
                    PolicyType = PolicyType.Boat,
                    PolicyNumber = "12M758811",
                    PolicyActiveDate = DateTime.Parse("02/22/2019"),
                    PolicyExpirationDate = DateTime.Parse("02/06/2020"),
                    PolicyPremium = Decimal.Parse("789")
                },

                new Policy {
                    PolicyName = "70 Colonese Road\nFairfield, CT 06825",
                    // TODO: Put images in a list, then make the images "swipeable" without swiping to the next policy
                    PolicyImageFileString = "SeventyColoneseRoad.png",
                    CompanyName = "Travelers",
                    PolicyType = PolicyType.Home,
                    PolicyNumber = "HP 658897",
                    PolicyActiveDate = DateTime.Parse("03/01/2019"),
                    PolicyExpirationDate = DateTime.Parse("10/31/2019"),
                    PolicyPremium = Decimal.Parse("1812")
                }
            };

            //loop back through to grab string values
            foreach (var policy in policies)
            {
                policy.PolicyTypeString = policy.PolicyType.ToString();
                policy.PolicyIconFileString = "policyIcon" + policy.PolicyTypeString + ".png";
                policy.PolicyActiveDateString = policy.PolicyActiveDate.ToShortDateString();
                policy.PolicyExpirationDateString = policy.PolicyExpirationDate.ToShortDateString();
                policy.PolicyPremiumString = "$" + policy.PolicyPremium.ToString();
                policy.PolicyExpirationDateFractionDouble = Math.Abs((365 / (policy.PolicyExpirationDate.Subtract(DateTime.Today).TotalDays)) - 1);
            }

            account.SetPolicies(policies);
            return account;
        }
    }
}
