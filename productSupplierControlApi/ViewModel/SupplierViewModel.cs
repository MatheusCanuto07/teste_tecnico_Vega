namespace productSupplierControl.ViewModel;

public class SupplierViewModel
{
    public int? Id { get; set; }
    public string? address { get; set; }
    public string? QRCode { get; set; }
    public SupplierViewModel(int? id, string? address, string? QRCode)
    {
        this.Id = id;
        this.address = address;
        this.QRCode = QRCode;
    }
}