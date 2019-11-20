using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public class UnitConfiguration : BaseEntityConfiguration<Unit>
    {
        public override void Configure(EntityTypeBuilder<Unit> builder)
        {
            base.Configure(builder);            
            builder.Property(p => p.Name).HasMaxLength(50);            
        }
    }
}
