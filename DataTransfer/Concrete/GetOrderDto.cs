using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class GetOrderDto : BaseDto
{
    public Int64 OrderCode { get; set; }
    public DateTime OrderDate { get; set; }
}