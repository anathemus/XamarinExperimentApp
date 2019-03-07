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

        public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string username)
        {
            this.Username = username;
        }

        // TODO : create secure methods to handle password, hashing, encryption, etc.

        public DateTime GetMemberSince()
        {
            return MemberSince;
        }

        public void SetMemberSince(DateTime startDate)
        {
            this.MemberSince = startDate;
        }

        public List<Policy> GetPolicies()
        {
            return Policies;
        }

        public void SetPolicies(List<Policy> policies)
        {
            this.Policies = policies;
        }

        public List<Setting> GetSettings()
        {
            return Settings;
        }

        public void SetSettings(List<Setting> settings)
        {
            this.Settings = settings;
        }
    }
}
