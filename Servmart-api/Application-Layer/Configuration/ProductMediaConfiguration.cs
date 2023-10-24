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
    public class ProductMediaConfiguration : IEntityTypeConfiguration<ProductMedia>
    {
        public void Configure(EntityTypeBuilder<ProductMedia> builder)
        {
            builder.ToTable("ProductMedia", "Product");
            builder.HasKey(m => m.ID);
            builder.Property(m => m.MeadiUrl).HasMaxLength(250).IsRequired();
            builder.HasOne(m => m.Product).WithMany(m => m.ProductMedias).HasForeignKey(m => m.ProductID);
        }
    }
}
