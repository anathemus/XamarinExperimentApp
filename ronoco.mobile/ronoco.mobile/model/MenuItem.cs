using ronoco.mobile.viewmodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ronoco.mobile.model
{
    public class MenuItem
    {
        public Icon MenuIcon { get; set; }
        public string MenuPageName { get; set; }
        public Type TargetPageType { get; set; }
    }
}
