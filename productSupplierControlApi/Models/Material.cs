namespace productSupplierControl.Models;

public class Material
{
  public int Id { get; set; }
  public int IdSupplier { get; set; }
  public string? Code { get; set; }
  public string Name { get; set; }
  public string? Description { get; set; }
  public string? FiscalCode { get; set; }
  public string? Specie { get; set; }
  public DateTime CreatedAt { get; set; }
  public string? CreatedBy { get; set; }
  public DateTime? UpdatedAt { get; set; }
  public string? UpdatedBy { get; set; }
  public Material(int id, int idSupplier, string? code, string? name, string? description, string? fiscalCode,
                    string? specie, DateTime createdAt, string? createdBy, DateTime? updatedAt, string? updatedBy)
    {
        Id = id;
        IdSupplier = idSupplier;
        Code = code;
        Name = name;
        Description = description;
        FiscalCode = fiscalCode;
        Specie = specie;
        CreatedAt = createdAt;
        CreatedBy = createdBy;
        UpdatedAt = updatedAt;
        UpdatedBy = updatedBy;
    }
  public Material(int id, string name){
    Id = id;
    Name = name;
  }
}