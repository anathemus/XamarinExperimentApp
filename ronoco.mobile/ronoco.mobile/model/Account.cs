using System;
using System.Collections.Generic;
using System.Text;

namespace ronoco.mobile.model
{
    class Account
    {
        private string Firstname;
        private string Lastname;
        private string EmailAddress;
        private string Username;
        private string Password;
        private DateTime MemberSince;
        private List<Policy> Policies;
        private List<Setting> Settings;

        public string GetFirstname()
        {
            return Firstname;
        }
        public void SetFirstname(string firstName)
        {
            this.Firstname = firstName;
        }
        public string GetLastname()
        {
            return Lastname;
        }
        public void SetLastname(string lastName)
        {
            this.Lastname = lastName;
        }
        public string GetEmail()
        {
            return EmailAddress;
        }
        public void SetEmail(string email)
        {
            this.EmailAddress = email;
        }
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
