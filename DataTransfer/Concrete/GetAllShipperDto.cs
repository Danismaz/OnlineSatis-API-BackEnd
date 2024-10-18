namespace DataTransfer.Concrete;

public class GetAllShipperDto
{
    public int ShipperCode { get; set; }
    public string ShipperName { get; set; }
    public string DeliveryTime { get; set; }
    public decimal Price { get; set; }
}