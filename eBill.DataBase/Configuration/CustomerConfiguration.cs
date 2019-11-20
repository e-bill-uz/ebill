using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class CustomerConfiguration:BaseEntityConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);            
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.Property(p => p.Address).HasMaxLength(300);
            builder.Property(p => p.INN).HasMaxLength(10);
            builder.Property(p => p.RegistrationCodeVAT).HasMaxLength(10); 
        }
    }
}
