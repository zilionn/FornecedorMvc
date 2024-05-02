using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fornecedor.App.ViewModels {
    public class ProductViewModel {
        
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid SupplierId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Description { get; set; }

        //public IFormFile ImageUpload { get; set; }

        [DisplayName("Imagem")]
        public string Image { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Value { get; set; }

        [DisplayName("Data de cadastro")]
        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }

        [DisplayName("Ativo?")]
        public bool IsActive { get; set; }
        public SupplierViewModel Supplier { get; set; }
    }
}
