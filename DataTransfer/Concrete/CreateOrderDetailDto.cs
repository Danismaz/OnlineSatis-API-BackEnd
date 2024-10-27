using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class CreateOrderDetailDto : BaseDto
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public Int64 OrderCode { get; set; }
    public Int64 ProductCode { get; set; }
}