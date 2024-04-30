using Fornecedor.Business.Models;

namespace Fornecedor.Business.Interfaces {
    public interface ISupplierRepository : IRepository<Supplier>{
        Task<Supplier> GetSupplierAddress(Guid id);
        Task<Supplier> GetSupplierProducts(Guid id);
    }
}
