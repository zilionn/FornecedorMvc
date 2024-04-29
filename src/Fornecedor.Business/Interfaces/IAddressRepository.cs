using Fornecedor.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Business.Interfaces {
    internal interface IAddressRepository : IRepository<Address>{
        Task<Address> GetAddressBySupplier(Guid suplierId);

    }
}
