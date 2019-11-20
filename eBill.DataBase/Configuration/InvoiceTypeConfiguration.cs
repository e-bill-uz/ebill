using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class InvoiceTypeConfiguration:BaseEntityConfiguration<InvoiceType>
    {
        public override void Configure(EntityTypeBuilder<InvoiceType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(200);
        }
    }
}
