using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Models.Accounts
{
    public class AccountModel : ModelBase
    {
        public Guid ClientId { get; set;}
        public string FullName { get ; set;}
        public string EmailAddress { get; set;}
        public string Password { get; set;}
        public DateTime LastLoggedIn { get; set;}

    }
}
