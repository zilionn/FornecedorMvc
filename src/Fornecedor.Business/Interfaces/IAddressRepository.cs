using Fornecedor.Business.Models;

namespace Fornecedor.Business.Interfaces {
    public interface IAddressRepository : IRepository<Address>{
        Task<Address> GetAddressBySupplier(Guid suplierId);

    }
}
