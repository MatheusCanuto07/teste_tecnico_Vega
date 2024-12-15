using Microsoft.EntityFrameworkCore;
using productSupplierControl.Models;

namespace productSupplierControl.Infraestrutura;

public class ConnecionContext : DbContext
{
    public DbSet<Material> Materials {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(
          "server=localhost;port=3306;uid=root;pwd=Gkt7198214@;database=vegaDb", ServerVersion.Parse("8.0.33-mysql"));
}