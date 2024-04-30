using Fornecedor.Business.Interfaces;
using Fornecedor.Business.Models;
using Fornecedor.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Fornecedor.Data.Repository {
    public class ProductRepository : Repository<Product>, IProductRepository {

        public ProductRepository(DataContext context) : base(context) { }
     
        public async Task<IEnumerable<Product>> GetProductsBySupplier(Guid supplierId) {
            return await Search(p => p.SupplierId == supplierId);
        }

        public async Task<IEnumerable<Product>> GetProductsSuppliers() {
            return await Data.Products.AsNoTracking().Include(s => s.Supplier)
                .OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Product> GetProductSupplier(Guid id) {
            return await Data.Products.AsNoTracking().Include(s => s.Supplier)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
