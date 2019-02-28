using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ronoco.mobile.model
{
    public class PolicyTypes
    {
        public enum PolicyType
        {
            Boat,
            Auto,
            Life
        }

        public static readonly BindableProperty TypeProperty =
        BindableProperty.Create("Type", typeof(PolicyType), typeof(PolicyTypes), null);
        public PolicyType Type
        {
            get { return this.Type; }
            set { this.Type = value; }
        }
    }
}