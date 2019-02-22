using System;
using System.Collections.Generic;
using System.Text;

namespace ronoco.mobile.model
{
    class DefaultAccount
    {
        public DefaultAccount()
        {
            Account DemoAccount = new Account();
            DemoAccount.SetUsername("default");
            DemoAccount.SetMemberSince(DateTime.Parse("2/4/2019"));

            Policy boatPolicyOne = new Policy();
            boatPolicyOne.SetPolicyName("2005 Boston Whaler Outrage");
            boatPolicyOne.SetCompanyName("Safeco");
            boatPolicyOne.SetPolicyType(PolicyType.Boat);
            boatPolicyOne.SetPolicyNumber("12M758811");
            boatPolicyOne.SetPolicyActiveDate(DateTime.Parse("2/22/2019"));
            boatPolicyOne.SetPolicyExpirationDate(DateTime.Parse("2/6/2020"));
            boatPolicyOne.SetPolicyPremium(Decimal.Parse("789"));
        }
    }
}
