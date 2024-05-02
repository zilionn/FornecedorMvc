using Fornecedor.Business.Enums;

namespace Fornecedor.Business.Models {
    public class Supplier : Entity {

        public string Name { get; set; }
        public string Document { get; set; }
        public SupplierType SupplierType { get; set; }
        public Address Address { get; set; }
        public bool IsActive { get; set; }

        /* EF RELATIONS */
        public IEnumerable<Product> Products { get; set; }

    }
}
