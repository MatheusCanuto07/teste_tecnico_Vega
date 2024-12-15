namespace productSupplierControl.Models;

public class Supplier
{
  public int? id {get; set;}
  public string? address {get; set;}
  public string? QRCode {get; set;}
  public Supplier(int? id, string? address, string? QRCode)
    {
        this.id = id;
        this.address = address;
        this.QRCode = QRCode;
    }
}