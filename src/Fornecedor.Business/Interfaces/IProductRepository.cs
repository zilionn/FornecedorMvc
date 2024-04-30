﻿using Fornecedor.Business.Models;

namespace Fornecedor.Business.Interfaces {
    public interface IProductRepository : IRepository<Product> {
        Task<IEnumerable<Product>> GetProductsBySupplier(Guid supplierId);
        Task<IEnumerable<Product>> GetProductsSuppliers();
        Task<Product> GetProductSupplier(Guid id);
    }
}
