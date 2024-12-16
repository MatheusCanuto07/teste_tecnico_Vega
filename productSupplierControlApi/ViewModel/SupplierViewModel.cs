namespace productSupplierControl.ViewModel;

public class SupplierViewModel
{
    public int? id {get; set;}
    public string? address {get; set;}
    public string? QRCode {get; set;}
    public string? cnpj {get; set;}
    public string? cep {get; set;}
    public string? name {get; set;}
    public SupplierViewModel(int? id, string? address, string? QRCode, string? cnpj, string? cep, string? name)
    {
        this.id = id;
        this.address = address;
        this.QRCode = QRCode;
        this.cnpj = cnpj;
        this.cep = cep;
        this.name = name;
    }
}