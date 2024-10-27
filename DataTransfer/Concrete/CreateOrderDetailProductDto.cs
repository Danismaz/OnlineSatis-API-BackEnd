namespace DataTransfer.Concrete;

public class CreateOrderDetailProductDto
{
    public Int64 ProductCode { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int Quantity { get; set; }
}