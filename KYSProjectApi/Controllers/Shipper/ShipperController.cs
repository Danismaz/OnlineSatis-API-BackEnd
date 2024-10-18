using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using Entities.Consts;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Shipper;

[ApiController]
[Route("api/[controller]")]
public class ShipperController(IShipperService shipperService) : ControllerBase
{
    [HttpGet("GetAllShipper")]
    public async Task<IActionResult> GetAllShipper()
    {
        var shippertList = await shipperService.GetFilteredListAsync
        (
            select: x => new GetAllShipperDto()
            {
                ShipperCode = x.ShipperCode,
                ShipperName = x.ShipperName,
                DeliveryTime = x.DeliveryTime,
                Price = x.Price
            },
            where: x => x.Status != Status.Passive,
            orderBy: x => x.OrderByDescending(z => z.CreatedDate)
        );

        if (shippertList.Count==0)
        {
            return NotFound();
        }

        return Ok(shippertList);
    }
}