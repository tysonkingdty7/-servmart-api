using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.DTOs;

namespace Application_Layer.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "User");
          
            builder.Property(u => u.FName).IsRequired().HasMaxLength(128);
            builder.Property(u => u.LName).IsRequired().HasMaxLength(128);
            builder.Property(u => u.SSN).IsRequired().HasMaxLength(14);
            builder.Property(u => u.Address).IsRequired().HasMaxLength(250);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(250);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.ProfilePic).IsRequired();

        }
    }
}
