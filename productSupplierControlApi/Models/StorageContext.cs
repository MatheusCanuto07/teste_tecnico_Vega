using Microsoft.EntityFrameworkCore;
namespace productSupplierControl.Models;

public class StorageContext : DbContext
{
    public StorageContext(DbContextOptions<StorageContext> options)
        : base(options)
    {
    }
    public DbSet<Supplier> SuppliersItems { get; set; } = null!;
    public DbSet<Material> MaterialItems { get; set;} = null!;
}