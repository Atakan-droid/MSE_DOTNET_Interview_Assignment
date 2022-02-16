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
            builder.Property(u => u.Temperature).IsRequired();
            builder.Property(u => u.Pressure).IsRequired();
            builder.Property(u => u.Status).IsRequired();
            builder.HasOne(u => u.ProductionLine).WithMany(u => u.Stations).HasForeignKey(u => u.LineId);
            builder.HasOne(u => u.MaintenanceStaff).WithMany(u => u.Stations).HasForeignKey(u => u.MaintenanceStaffId);

            var initialStation = new Station
            {
                Id = 1,
                LineId=1,
                StationName="Birinci istasyon",
                Status="Çalışıyor",
                MaintenanceStaffId=2,
                Pressure=108,
                Temperature=50,        
            };
            var initialStation2 = new Station
            {
                Id = 2,
                LineId = 3,
                StationName = "Ikinci istasyon",
                Status = "Çalışıyor",
                MaintenanceStaffId = 3,
                Pressure = 8,
                Temperature = 1,
            };
            var initialStation3 = new Station
            {
                Id = 3,
                LineId = 2,
                StationName = "Ücüncü istasyon",
                Status = "Çalışıyor",
                MaintenanceStaffId = 2,
                Pressure = 158,
                Temperature = 2000,
            };
            builder.HasData(initialStation,initialStation2,initialStation3);
        }
    }
}
