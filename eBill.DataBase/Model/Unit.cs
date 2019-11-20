using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class Unit:EntityBase
    {
        public string Name { get; set; }

        [AllowNull]
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
