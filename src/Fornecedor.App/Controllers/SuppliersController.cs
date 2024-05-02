using AutoMapper;
using Fornecedor.App.ViewModels;
using Fornecedor.Business.Interfaces;
using Fornecedor.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedor.App.Controllers {
    public class SuppliersController : Controller {

        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;
        public SuppliersController(ISupplierRepository supplierRepository, IMapper mapper) {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index() {
            return View(_mapper.Map<IEnumerable<SupplierViewModel>>(await _supplierRepository.GetAll()));
        }

        public async Task<IActionResult> Details(Guid id) {
            var supplierViewModel = await GetSupplierAddress(id);

            if (supplierViewModel == null) {
                return NotFound();
            }

            return View(supplierViewModel);
        }

        public IActionResult Create() {
            return View();
        }

        public async Task<IActionResult> Create(SupplierViewModel supplierViewModel) {
            if (!ModelState.IsValid) return View(supplierViewModel);

            var supplier = _mapper.Map<Supplier>(supplierViewModel);
            await _supplierRepository.Add(supplier);

            return RedirectToAction("Index");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, SupplierViewModel supplierViewModel) {
            if (id != supplierViewModel.Id) return NotFound();

            if(!ModelState.IsValid) return View(supplierViewModel);

            var supplier = _mapper.Map<Supplier>(supplierViewModel);
            await _supplierRepository.Update(supplier);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id) {
            var supplier = await GetSupplierAddress(id);

            if (supplier != null) return NotFound();

            await _supplierRepository.Delete(id);

            return RedirectToAction("Index");
        }

        private async Task<SupplierViewModel> GetSupplierAddress(Guid id) {
            return _mapper.Map<SupplierViewModel>(await _supplierRepository.GetSupplierAddress(id));
        }

        private async Task<SupplierViewModel> GetSupplierProducts(Guid id) {
            return _mapper.Map<SupplierViewModel>(await _supplierRepository.GetSupplierProducts(id));
        }
    }
}
