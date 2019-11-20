using Newtonsoft.Json;
using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class InvoiceDetail:EntityBase
    {
        [JsonIgnore]
        [AllowNull]
        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public int OrderNo { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        [AllowNull]
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal VATRate { get; set; }
        public decimal AmountOfVAT { get; set; }
        public decimal DeliveryCostIncludingVAT { get; set; }
    }
}
