using Microsoft.AspNetCore.Identity;
using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class ApplicationUser:IdentityUser
    {
        [AllowNull]
        public string LastName { get; set; }
        [AllowNull]
        public string FirstName { get; set; }
        [AllowNull]
        public string FatherName { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string RegistrationCodeVAT { get; set; }        
        public ICollection<Invoice> Invoices { get; set; }
    }
}
