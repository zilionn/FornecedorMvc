﻿using Fornecedor.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Fornecedor.Data.Mappings {
    public class SupplierMapping : IEntityTypeConfiguration<Supplier> {

        public void Configure(EntityTypeBuilder<Supplier> builder) {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Document)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.HasOne(x => x.Address)
                .WithOne(x => x.Supplier);

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Supplier)
                .HasForeignKey(x => x.SupplierId);

            builder.ToTable("Suppliers");
        
        }

    }
}
