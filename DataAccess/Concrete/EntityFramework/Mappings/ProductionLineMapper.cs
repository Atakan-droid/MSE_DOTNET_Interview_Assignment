using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductionLineMapper : IEntityTypeConfiguration<ProductionLine>
    {
        public void Configure(EntityTypeBuilder<ProductionLine> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.LineName).IsRequired();
            builder.HasMany(u => u.Stations).WithOne(u => u.ProductionLine).HasForeignKey(u => u.LineId);
        }
    }
}
