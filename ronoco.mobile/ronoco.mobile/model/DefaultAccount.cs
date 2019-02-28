﻿using ronoco.mobile.viewmodel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class DefaultAccount
    {
        public ObservableCollection<Policy> Policies { get; set; }
        public DefaultAccount()
        {
            Account DemoAccount = new Account();
            DemoAccount.SetUsername("default");
            DemoAccount.SetMemberSince(DateTime.Parse("2/4/2019"));

            Policy BoatPolicyOne = new Policy();
            BoatPolicyOne.SetPolicyName("2005 Boston Whaler Outrage");
            BoatPolicyOne.SetCompanyName("Safeco");
            BoatPolicyOne.SetPolicyType(PolicyTypes.PolicyType.Boat);
            BoatPolicyOne.SetPolicyNumber("12M758811");
            BoatPolicyOne.SetPolicyActiveDate(DateTime.Parse("2/22/2019"));
            BoatPolicyOne.SetPolicyExpirationDate(DateTime.Parse("2/6/2020"));
            BoatPolicyOne.SetPolicyPremium(Decimal.Parse("789"));

            Policies = new ObservableCollection<Policy>();
            Policies.Add(BoatPolicyOne);
        }
    }
}
