using System;
using System.Linq;

namespace ronoco.mobile.model
{
    public class Policy
    {
        private string PolicyName;
        private string CompanyName;
        private string PolicyNumber;
        private PolicyTypes.PolicyType PolicyType;
        private DateTime PolicyActiveDate;
        private DateTime PolicyExpirationDate;
        private decimal PolicyPremium;
        private double PolicyExpirationDateFractionDouble;

        public string GetPolicyName()
        {
            return PolicyName;
        }
        public void SetPolicyName(string policyName)
        {
            this.PolicyName = policyName;
        }
        public string GetCompanyName()
        {
            return CompanyName;
        }

        public void SetCompanyName(string name)
        {
            this.CompanyName = name;
        }

        public string GetPolicyNumber()
        {
            return PolicyNumber;
        }

        public void SetPolicyNumber(string number)
        {
            this.PolicyNumber = number;
        }
        public PolicyTypes.PolicyType GetPolicyType()
        {
            return PolicyType;
        }
        public void SetPolicyType(PolicyTypes.PolicyType policyType)
        {
            this.PolicyType = policyType;
        }
        public DateTime GetPolicyActiveDate()
        {
            return PolicyActiveDate;
        }

        public void SetPolicyActiveDate(DateTime activeDate)
        {
            this.PolicyActiveDate = activeDate;
        }

        public DateTime GetPolicyExpirationDate()
        {
            return PolicyExpirationDate;
        }

        public void SetPolicyExpirationDate(DateTime expirationDate)
        {
            this.PolicyExpirationDate = expirationDate;
        }

        public decimal GetPolicyPremium()
        {
            return PolicyPremium;
        }

        public void SetPolicyPremium(decimal premium)
        {
            this.PolicyPremium = premium;
        }

        public double GetPolicyExpirationDateFractionDouble()
        {
            return (365 / (PolicyExpirationDate - DateTime.Today).TotalDays) / 100;
        }
    }
}