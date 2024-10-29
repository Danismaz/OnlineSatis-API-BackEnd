using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class DeleteProductDto :BaseDto
{
    public Int64 ProductCode { get; set; }    
    public string ProductName { get; set; }       
    public decimal ProductPrice { get; set; }       
    public int Stock { get; set; }

    public Int64 CategoryCode { get; set; }
}