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

    public class ProductConfigurstion : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", "Product");
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.HasOne(p => p.Category).WithMany(c => c.Prouducts).HasForeignKey(p => p.CategoryID);
            builder.HasOne(p => p.Shop).WithMany(s => s.Products).HasForeignKey(p => p.ShopID);
        }
    }
}
