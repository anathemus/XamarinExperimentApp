using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.interfaces
{
    interface IPolicyCell
    {
        Label TypeLabel { get; set; }
        Image Icon { get; set; }
        Label PremiumLabel { get; set; }
        Label CompanyLabel { get; set; }
        Label ExpirationLabel { get; set; }
        ProgressBar ExpirationBar { get; set; }
    }
}
