using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service", "Service");
            builder.HasKey(D => D.ID);
            builder.Property(n => n.Title).IsRequired().HasMaxLength(250);
            builder.Property(D => D.Discription).IsRequired().HasMaxLength(250);
            builder.Property(r => r.Rate).IsRequired().HasColumnType("float");
            builder.Property(E => E.ExpectedSalary).IsRequired().HasColumnType("float");
            builder.HasOne(e => e.ServiceCategory).WithMany(e => e.Services).HasForeignKey(e => e.CategoryID).IsRequired();
            builder.HasOne(e => e.User).WithMany(e => e.Services).HasForeignKey(e => e.ProviderID).IsRequired();
        }
    }
}
