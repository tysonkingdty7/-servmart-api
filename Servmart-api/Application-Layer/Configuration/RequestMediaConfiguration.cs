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
    public class RequestMediaConfiguration : IEntityTypeConfiguration<RequestMedia>
    {
        public void Configure(EntityTypeBuilder<RequestMedia> builder)
        {
            builder.ToTable("RequestMedia", "Service");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(m => m.MediaUrl).IsRequired().HasMaxLength(500);
            builder.HasOne(i => i.Request).WithMany(i => i.Media).HasForeignKey(i => i.RequestID).IsRequired();

        }
    }
}
