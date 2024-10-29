using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class CreateProductDto : BaseDto
{
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int Stock { get; set; }

    public Int64 CategoryCode { get; set; }
}