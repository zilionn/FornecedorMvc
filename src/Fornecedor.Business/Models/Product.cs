using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Business.Models {
    public class Product : Entity {

        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }

        /* EF RELATION */
        public Supplier Supplier { get; set; } 

    }
}
