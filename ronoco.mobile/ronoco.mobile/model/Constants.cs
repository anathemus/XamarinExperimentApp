using System;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    class Constants
    {
        public static Label ONBOARDING_CAROUSEL_ONE_HEADER_TXT = new Label
        {
            Text = "Track your Coverages",
            FontFamily = "SFUIDisplay-Medium",
            FontSize = 26
        };

        public static Label ONBOARDING_CAROUSEL_ONE_DESCRIPTION_TXT = new Label
        {
            Text = "All your policies are pulled together in one place so you don’t have to go digging around just " +
                            "to get the information you need when you need it.",
            FontFamily = "SFUIText-Medium",
            FontSize = 12
        };

        public static Label ONBOARDING_CAROUSEL_TWO_HEADER_TXT = new Label
        {
            Text = "Get Solid Advice",
            FontFamily = "SFUIDisplay-Medium",
            FontSize = 26
        };

        public static Label ONBOARDING_CAROUSEL_TWO_DESCRIPTION_TXT = new Label
        {
            Text = "No hold time on calls. No rearranging your schedule. No paperwork. No hassle.",
            FontFamily = "SFUIText-Medium",
            FontSize = 12
        };

        public static Label ONBOARDING_CAROUSEL_THREE_HEADER_TXT = new Label
        {
            Text = "Find Savings Fast",
            FontFamily = "SFUIDisplay-Medium",
            FontSize = 26
        };

        public static Label ONBOARDING_CAROUSEL_THREE_DESCRIPTION_TXT = new Label
        {
            Text = "Public data important for your rates is automatically incorporated. That helps us let " +
                            "you know when a better rate or coverage is available.",
            FontFamily = "SFUIText-Medium",
            FontSize = 12
        };
    }
}
