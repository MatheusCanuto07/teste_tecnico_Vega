namespace productSupplierControl.Models;

public interface ISupplierRepository
{
    void add(Supplier s);

    List<Supplier> Get();
}