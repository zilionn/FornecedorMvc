using Fornecedor.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Business.Interfaces {
    public interface ISupplierRepository : IRepository<Supplier>{
        Task<Supplier> GetSupplierByAddress(Guid id);
        Task<Supplier> GetSupplierProducts(Guid id);
    }
}
