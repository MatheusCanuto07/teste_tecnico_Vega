using Microsoft.AspNetCore.Mvc;
using productSupplierControl.Models;
using productSupplierControl.ViewModel;

namespace productSupplierControl.Controllers;

[ApiController]
[Route("api/v1/supplier")]
public class SupplierController : ControllerBase
{
  private readonly ISupplierRepository _supplierRepository;
  public SupplierController (ISupplierRepository supplierRepository)
  {
    _supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
  }

  [HttpPost]
  public IActionResult Add(SupplierViewModel s){
    var supplier = new Supplier(s.Id, s.address, s.QRCode);

    _supplierRepository.add(supplier);
    return Ok();
  }
  [HttpGet]
  public IActionResult GetAll(){
    var supplier = _supplierRepository.Get();
    return Ok(supplier);
  }

}