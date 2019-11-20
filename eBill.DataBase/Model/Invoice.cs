using Newtonsoft.Json;
using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class Invoice :EntityBase
    {
        public string InvoiceNo { get; set; }
        public string ShippingDocumentNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string SupplierId { get; set; }
        [JsonIgnore]
        [AllowNull]
        public Customer Customer { get; set; }        
        public int CustomerId { get; set; }        
        public string Director { get; set; }
        public string ChiefAccountant { get; set; }
        public string ProductDispenser { get; set; }
        public string ProxyName { get; set; }
        public string ProxyNo { get; set; }
        public DateTime ProxyDate { get; set; }

        [AllowNull]
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }


    }
}
