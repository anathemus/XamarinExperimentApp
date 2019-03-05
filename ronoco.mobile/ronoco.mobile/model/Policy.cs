using ronoco.mobile.interfaces;
using System;
using System.Linq;

namespace ronoco.mobile.model
{
    public class Policy : IPolicy
    {
        public string PolicyName { get; set; }
        public string CompanyName { get; set; }
        public string PolicyNumber { get; set; }
        public PolicyType PolicyType { get; set; }
        public DateTime PolicyActiveDate { get; set; }
        public DateTime PolicyExpirationDate { get; set; }
        public decimal PolicyPremium { get; set; }
        public double PolicyExpirationDateFractionDouble { get; set; }
        public string PolicyTypeString { get; set; }
        public string PolicyActiveDateString { get; set; }
        public string PolicyExpirationDateString { get; set; }
        public string PolicyPremiumString { get; set; }
        public string PolicyIconFileString { get; set; }
        public string PolicyImageFileString { get; set; }

        public Policy()
        {
            //PolicyTypeString = PolicyType.ToString();
            //PolicyActiveDateString = PolicyActiveDate.ToShortDateString();
            //PolicyExpirationDateString = PolicyExpirationDate.ToShortDateString();
            //PolicyPremiumString = PolicyPremium.ToString();
        }
    }
}