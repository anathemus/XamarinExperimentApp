using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class DefaultAccount
    {
        public List<Policy> Policies { get; set; }
        //public Policy BoatPolicyOne { get; set; }
        public DefaultAccount()
        {
            Account DemoAccount = new Account();
            DemoAccount.SetUsername("default");
            DemoAccount.SetMemberSince(DateTime.Parse("2/4/2019"));

            Policy BoatPolicyOne = new Policy();
            BoatPolicyOne.SetPolicyName("2005 Boston Whaler Outrage");
            BoatPolicyOne.SetCompanyName("Safeco");
            BoatPolicyOne.SetPolicyType(PolicyType.Boat);
            BoatPolicyOne.SetPolicyNumber("12M758811");
            BoatPolicyOne.SetPolicyActiveDate(DateTime.Parse("2/22/2019"));
            BoatPolicyOne.SetPolicyExpirationDate(DateTime.Parse("2/6/2020"));
            BoatPolicyOne.SetPolicyPremium(Decimal.Parse("789"));

            Policies = new List<Policy>
            {
                BoatPolicyOne
            };
        }

        public List<ImageCell> PolicyImageCells()
        {
            List<ImageCell> imageCells = new List<ImageCell>();
            foreach (var policy in Policies)
            {

            }

            return imageCells;
        }
    }
}
