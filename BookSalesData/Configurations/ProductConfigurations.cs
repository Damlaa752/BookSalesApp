using BookSalesCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesData.Configurations
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image).HasMaxLength(100);
            builder.Property(x => x.ProductCode).HasMaxLength(50);
            builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(f => f.BrandId);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(c => c.CategoryId);
        }
    }
}
