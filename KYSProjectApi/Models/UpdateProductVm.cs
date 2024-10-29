namespace KYSProjectApi.Models;

public class UpdateProductVm
{
    public Int64 ProductCode { get; set; }
    public string Name { get; set; }
    public decimal ProductPrice { get; set; }
    public int Stock { get; set; }

    public Int64 CategoryCode { get; set; }
}