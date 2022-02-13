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
    public class StationMapper : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Heat).IsRequired();
            builder.Property(u => u.Pressure).IsRequired();
            builder.Property(u => u.Status).IsRequired();
            builder.HasOne(u => u.ProductionLine).WithMany(u => u.Stations).HasForeignKey(u => u.LineId);
            builder.HasOne(u => u.MaintenanceStaff).WithMany(u => u.Stations).HasForeignKey(u => u.MaintenanceStaffId);
        }
    }
}
