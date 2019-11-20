using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class InvoiceType:EntityBase
    {
        public string Name { get; set; }

        [AllowNull]
        public ICollection<Invoice> Invoices { get; set; }
    }
}
