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

            var initialLine = new ProductionLine
            {
                Id = 1,
                LineName="A Üretim Yolu",
            };
            var initialLine2 = new ProductionLine
            {
                Id = 2,
                LineName = "B Üretim Yolu",
            };
            var initialLine3 = new ProductionLine
            {
                Id = 3,
                LineName = "C Üretim Yolu",
            };
            var initialLine4 = new ProductionLine
            {
                Id = 4,
                LineName = "D Üretim Yolu",
            };
            builder.HasData(initialLine,initialLine2,initialLine3,initialLine4);
        }
    }
}
