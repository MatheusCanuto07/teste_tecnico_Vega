using productSupplierControl.Models;

namespace productSupplierControl.Infraestrutura;

public class MaterialRepository : IMaterialRepository
{

  private readonly ConnecionContext _context = new ConnecionContext();
  public void add(Material m)
  {
    _context.Materials.Add(m);
    _context.SaveChanges();
  }

  public List<Material> Get()
  {
    return _context.Materials.ToList();
  }
}