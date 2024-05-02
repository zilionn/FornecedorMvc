﻿using Fornecedor.Business.Enums;
using Fornecedor.Business.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fornecedor.App.ViewModels {
    public class SupplierViewModel {

        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Documento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Document { get; set; }

        [DisplayName("Tipo")]
        public int SupplierType { get; set; }
        public AddressViewModel Address { get; set; }

        [DisplayName("Ativo?")]
        public bool IsActive { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
