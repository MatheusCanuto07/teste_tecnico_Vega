using Microsoft.AspNetCore.Mvc;
using productSupplierControl.Models;
using productSupplierControl.ViewModel;

namespace productSupplierControl.Controllers;


[ApiController]
[Route("api/v1/material")]
public class MaterialController : ControllerBase
{

  private readonly IMaterialRepository _materialRepository;
  public MaterialController (IMaterialRepository materialRepository)
  {
    _materialRepository = materialRepository ?? throw new ArgumentNullException(nameof(materialRepository));
  }
  
  [HttpPost]
  public IActionResult Add(MaterialViewModel m){
    var material = new Material(m.Id, m.Name);

    _materialRepository.add(material);
    return Ok();
  }
  [HttpGet]
  public IActionResult GetAll(){
    var materials = _materialRepository.Get();
    return Ok(materials);
  }
}