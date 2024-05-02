using AutoMapper;
using Fornecedor.App.ViewModels;
using Fornecedor.Business.Models;

namespace Fornecedor.App.AutoMapper {
    public class AutoMapperConfig : Profile {

        public AutoMapperConfig() {
            CreateMap<Supplier, SupplierViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
        }
    }
}
