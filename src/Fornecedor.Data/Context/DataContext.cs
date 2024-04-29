using Fornecedor.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Data.Context {
    public class DataContext : DbContext {

        public DataContext(DbContextOptions options) : base(options) { 
        
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

            foreach(var relation in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
                relation.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);        
        }
    }
}
