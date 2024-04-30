using Fornecedor.Business.Interfaces;
using Fornecedor.Business.Models;
using Fornecedor.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Fornecedor.Data.Repository {
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository {

        public SupplierRepository(DataContext context) : base(context) { }
            
        public async Task<Supplier> GetSupplierAddress(Guid id) {
            return await Data.Suppliers.AsNoTracking()
                .Include(a => a.Address)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Supplier> GetSupplierProducts(Guid id) {
            return await Data.Suppliers.AsNoTracking().Include(a => a.Products).FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
