using System;
using System.Linq;

namespace ronoco.mobile.model
{
    public class Policy
    {
        public string PolicyName { get; set; }
        public string CompanyName { get; set; }
        public string PolicyNumber;
        public PolicyTypes.PolicyType PolicyType;
        public DateTime PolicyActiveDate;
        public DateTime PolicyExpirationDate = DateTime.MinValue;
        public decimal PolicyPremium;
        public double PolicyExpirationDateFractionDouble;
        public Policy()
        {
            PolicyName = "";
            CompanyName = "hodor";
            string PolicyNumber = "";
            PolicyTypes.PolicyType PolicyType = PolicyTypes.PolicyType.Auto;
            DateTime PolicyActiveDate = DateTime.MinValue;
            DateTime PolicyExpirationDate = DateTime.MinValue;
            decimal PolicyPremium = 1.0M;
            double PolicyExpirationDateFractionDouble = (365 / (PolicyExpirationDate - DateTime.Today).TotalDays) / 100;
        }
        //public string GetPolicyName()
        //{
        //    return PolicyName;
        //}
        //public void SetPolicyName(string policyName)
        //{
        //    this.PolicyName = policyName;
        //}
        //public string GetCompanyName()
        //{
        //    return CompanyName;
        //}

        //public void SetCompanyName(string name)
        //{
        //    this.CompanyName = name;
        //}

        //public string GetPolicyNumber()
        //{
        //    return PolicyNumber;
        //}

        //public void SetPolicyNumber(string number)
        //{
        //    this.PolicyNumber = number;
        //}
        //public string GetPolicyType()
        //{
        //    return this.PolicyType.ToString();
        //}
        //public void SetPolicyType(PolicyTypes.PolicyType policyType)
        //{
        //    this.PolicyType = policyType;
        //}
        //public DateTime GetPolicyActiveDate()
        //{
        //    return PolicyActiveDate;
        //}

        //public void SetPolicyActiveDate(DateTime activeDate)
        //{
        //    this.PolicyActiveDate = activeDate;
        //}

        //public DateTime GetPolicyExpirationDate()
        //{
        //    return PolicyExpirationDate;
        //}

        //public void SetPolicyExpirationDate(DateTime expirationDate)
        //{
        //    this.PolicyExpirationDate = expirationDate;
        //}

        //public decimal GetPolicyPremium()
        //{
        //    return PolicyPremium;
        //}

        //public void SetPolicyPremium(decimal premium)
        //{
        //    this.PolicyPremium = premium;
        //}

        //public double GetPolicyExpirationDateFractionDouble()
        //{
        //    return (365 / (PolicyExpirationDate - DateTime.Today).TotalDays) / 100;
        //}
    }
}