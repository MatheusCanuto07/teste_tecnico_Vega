using productSupplierControl.Models;

namespace productSupplierControl.Infraestrutura;

public class SupplierRepository : ISupplierRepository
{
  private readonly ConnecionContext _context = new ConnecionContext();
  public void add(Supplier s)
  {
    _context.Supplier.Add(s);
    _context.SaveChanges();
  }

  public List<Supplier> Get()
  {
    return _context.Supplier.ToList();
  }
}