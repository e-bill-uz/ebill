using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class Customer:EntityBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string RegistrationCodeVAT { get; set; }

        [AllowNull]
        public ICollection<Invoice> Invoices { get; set; }
    }
}
