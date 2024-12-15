namespace productSupplierControl.Models;

public interface IMaterialRepository
{
    void add(Material m);

    List<Material> Get();
}