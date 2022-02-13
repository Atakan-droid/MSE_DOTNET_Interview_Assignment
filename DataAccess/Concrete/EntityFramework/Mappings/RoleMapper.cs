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
    public class RoleMapper : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.RoleName).IsRequired();
            builder.HasMany(r => r.Users).WithOne(r => r.Role).HasForeignKey(r => r.RoleID);

            builder.ToTable("Roles");
            var initialRoles = new List<Role> {
            new Role{Id=1,RoleName="Admin"},
            new Role{Id=2,RoleName="Bakım Personeli"},
            new Role{Id=3,RoleName="Kullanıcı"},
            };

            builder.HasData(initialRoles);
        }
    }
}
