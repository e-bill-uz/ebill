using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class InvoiceDetailConfiguration : BaseEntityConfiguration<InvoiceDetail>
    {
        public override void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Unit).WithMany(t => t.InvoiceDetails).HasForeignKey(p => p.UnitId);                        
            builder.HasOne(p => p.Invoice).WithMany(t => t.InvoiceDetails).HasForeignKey(p => p.InvoiceId);                                    
            builder.Property(p => p.OrderNo).IsRequired();
            builder.Property(p => p.Title).HasMaxLength(400);
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.UnitPrice).IsRequired();
            builder.Property(p => p.DeliveryCost).IsRequired();
            builder.Property(p => p.VATRate).IsRequired();
            builder.Property(p => p.AmountOfVAT).IsRequired();
            builder.Property(p => p.DeliveryCostIncludingVAT).IsRequired();            
        }
    }
}
