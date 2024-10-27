using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using Entities.Consts;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Product;

[Route("api/[controller]")]
[ApiController]
public class ProductController (IProductService productService) : ControllerBase
{
    [HttpGet ("GetAllProduct")]
    public async Task<IActionResult> GetAllProduct()
    {
        // var productList = await productService.GetFilteredListAsync();
        
        var productList = await productService.GetFilteredListAsync
        (
            select: x => new GetAllProductDto()
            {
                ProductCode = x.ProductCode,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                Stock = x.Stock,
                CategoryCode = x.CategoryCode
            },
            where: x => x.Status != Status.Passive,
            orderBy: x => x.OrderByDescending(z => z.CreatedDate)
        );

        return Ok(productList);
    }

    [HttpGet("GetProduct/{id}")]
    public async Task<IActionResult> GetProduct(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return BadRequest("Product ID is required.");
        }

        if (!long.TryParse(id, out long productCode))
        {
            return BadRequest("Invalid Product ID format.");
        }

        var product = await productService.GetByIdAsync<GetAllProductDto>(x => x.ProductCode == productCode && x.Status != Status.Passive);

        if (product == null)
        {
            return NotFound(); // Ürün bulunamazsa 404 döndür
        }

        return Ok(product);
    }

    [HttpGet("GetProductsByCategory/{id}")]
    public async Task<IActionResult> GetProductsByCategory(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return BadRequest("Category ID is required.");
        }
        if (!long.TryParse(id, out long categoryCode))
        {
            return BadRequest("Invalid Category ID format.");
        }
        var product = await productService.GetByDefaultListAsync<GetAllProductDto>(x => x.CategoryCode == categoryCode && x.Status != Status.Passive);

        if (product == null)
        {
            return NotFound(); // Ürün bulunamazsa 404 döndür
        }

        return Ok(product);
    }
}