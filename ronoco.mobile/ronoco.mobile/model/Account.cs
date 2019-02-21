using System;
using System.Collections.Generic;
using System.Text;

namespace ronoco.mobile.model
{
    class Account
    {
        private string Username;
        private string Password;
        private DateTime MemberSince;
        private List<Policy> Policies;
        private List<Setting> Settings;
    }
}
