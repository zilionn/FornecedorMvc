using Fornecedor.Business.Interfaces;
using Fornecedor.Business.Models;
using Fornecedor.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Data.Repository {
    public class AddressRepository : Repository<Address>, IAddressRepository {

        public AddressRepository(DataContext context) : base(context) { }
 
        public async Task<Address> GetAddressBySupplier(Guid suplierId) {
            return await Data.Addresses.AsNoTracking()
                .FirstOrDefaultAsync(a => a.SupplierId == suplierId);
        }
    }
}
