using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor.Business.Models {
    public class Address : Entity {

        public Guid SupplierId { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; } 
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        /* EF RELATION */
        public Supplier Supplier { get; set; }
    }
}
