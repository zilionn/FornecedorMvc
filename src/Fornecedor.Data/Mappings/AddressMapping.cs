using Fornecedor.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fornecedor.Data.Mappings {
    public class AddressMapping : IEntityTypeConfiguration<Address> {

        public void Configure(EntityTypeBuilder<Address> builder) {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StreetName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Neighborhood)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.City)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Number)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.Property(x => x.State)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(x => x.Complement)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.ToTable("Addresses");
        }
    }
}
