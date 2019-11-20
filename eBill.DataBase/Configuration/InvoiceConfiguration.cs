using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class InvoiceConfiguration : BaseEntityConfiguration<Invoice>
    {
        public override void Configure(EntityTypeBuilder<Invoice> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Customer).WithMany(t => t.Invoices).HasForeignKey(p => p.CustomerId);
            builder.HasOne(p => p.ApplicationUser).WithMany(t => t.Invoices).HasForeignKey(p => p.SupplierId);
            builder.Property(p => p.InvoiceNo).HasMaxLength(20);
            builder.Property(p => p.ShippingDocumentNo).HasMaxLength(20);            
            builder.Property(p => p.StartDate).HasColumnType("DATE");
            builder.Property(p => p.EndDate).HasColumnType("DATE");
            builder.Property(p => p.Director).HasMaxLength(150);
            builder.Property(p => p.ChiefAccountant).HasMaxLength(150);
            builder.Property(p => p.ProductDispenser).HasMaxLength(150);
            builder.Property(p => p.ProxyName).HasMaxLength(150);
            builder.Property(p => p.ProxyNo).HasMaxLength(150);
            builder.Property(p => p.ProxyDate).HasColumnType("DATE");

        }
    }
}

