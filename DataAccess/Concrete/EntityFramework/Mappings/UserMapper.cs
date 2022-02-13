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
    public class UserMapper : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Mail).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Surname).IsRequired();
            builder.HasOne(u => u.Role).WithMany(u => u.Users).HasForeignKey(u => u.RoleID);

            var initialAdmin = new User
            {
                Id = 1,
                Name = "adminuser",
                Surname = "ADMINUSER",
                Mail = "adminuser@gmail.com",
                Password = "Ab123456789",
                RoleID = 1,

            };
            builder.HasData(initialAdmin);
        }
    }
}
