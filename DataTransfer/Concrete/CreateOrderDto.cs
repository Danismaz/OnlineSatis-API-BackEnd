using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class CreateOrderDto : BaseDto
{
    public DateTime OrderDate { get; set; }
    public Int64 UserCode { get; set; }
    public int ShipperCode { get; set; }
}