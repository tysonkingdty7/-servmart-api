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
    public class ProductRateconfigurstion : IEntityTypeConfiguration<ProductRate>
    {
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.ToTable("ProductRate", "Product");
            builder.HasKey(x => x.ID);
            builder.Property(r => r.Description).HasMaxLength(250).IsRequired();
            builder.Property(r => r.Rate).IsRequired();
            builder.HasOne(P => P.Product).WithMany(Pr => Pr.ProductRates).HasForeignKey(x => x.ProductId);
        }
    }
}
