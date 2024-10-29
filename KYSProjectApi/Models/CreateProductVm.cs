namespace KYSProjectApi.Models;

public class CreateProductVm
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public Int64 CategoryCode { get; set; }
}