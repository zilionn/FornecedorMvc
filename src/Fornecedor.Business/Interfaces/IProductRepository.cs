using Fornecedor.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Business.Interfaces {
    public interface IProductRepository : IRepository<Product> {
        Task<IEnumerable<Product>> GetProductsBySupplier(Guid supplierId);
        Task<IEnumerable<Product>> GetProductsSuppliers();
        Task<Product> GetProductSupplier(Guid id);
    }
}
