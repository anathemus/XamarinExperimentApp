using System;
using System.Collections.Generic;
using System.Text;
using ronoco.mobile.model;

namespace ronoco.mobile.interfaces
{
    interface IPolicy
    {
        string PolicyName { get; set; }
        string CompanyName { get; set; }
        string PolicyNumber { get; set; }
        PolicyType PolicyType { get; set; }
        string PolicyTypeString { get; set; }
        DateTime PolicyActiveDate { get; set; }
        string PolicyActiveDateString { get; set; }
        DateTime PolicyExpirationDate { get; set; }
        string PolicyExpirationDateString { get; set; }
        decimal PolicyPremium { get; set; }
        string PolicyPremiumString { get; set; }
        double PolicyExpirationDateFractionDouble { get; set; }
        string PolicyIconFileString { get; set; }
        string PolicyImageFileString { get; set; }
    }
}
