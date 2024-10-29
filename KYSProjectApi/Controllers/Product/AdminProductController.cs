using AutoMapper;
using Business.ActionFilters;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using Entities.Consts;
using KYSProjectApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Product;

[Route("api/[controller]")]
[ApiController]
public class AdminProductController : ControllerBase
{
    
    private readonly IProductService _productService;
    private readonly IMapper _mapper;
    public AdminProductController(IProductService productService,IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }
    [HttpGet("GetProduct")]
   public async Task<IActionResult> GetProduct() 
    {
        var products = await _productService.GetFilteredListAsync
            (
            select: x => new GetProductsDto
            {
                ProductCode = x.ProductCode,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                Stock = x.Stock,
                CategoryName = x.Category.CategoryName,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                Status = x.Status,
            },
            where: x => x.Status != Status.Passive && x.Category.Status != Status.Passive,
            orderBy: x => x.OrderByDescending(z => z.CreatedDate)
            );
        return Ok(products);
    }
    [HttpGet("GetProductById")]
    public async Task<IActionResult> GetProductById(Int64 id)
    {
        var product = await _productService.GetByIdAsync<GetProductsDto>(x=>x.ProductCode == id);
        if(product == null)
        {
            return NotFound("Ürün bulunamadı!!");
        }
        var productDto=_mapper.Map<GetProductsDto>(product);
        return Ok(productDto);
    }
    [HttpPost("CreateProduct")]
    public async Task<IActionResult> CreateProduct([FromForm] CreateProductVm model)
    {
        if (model == null)
            return BadRequest("Bir şeyler ters gitti!");

        if (await _productService.AnyAsync(x => x.ProductName == model.Name))
            return BadRequest("Bu isimde bir ürün var. Farklı bir isim seçiniz!");
        var dto = new CreateProductDto
        {
            ProductName = model.Name,
            ProductPrice = model.Price,
            Stock=model.Stock,
            CreatedDate = DateTime.Now,
            Status = Status.Active,
            CategoryCode=model.CategoryCode,
           
        };
        var result =await _productService.AddAsync(dto);
        if (result is false)
        {
            return BadRequest("İşlem yapılırken bir sorun oluştu.");
        }
        return Ok($"Ürün başarıyla eklenmiştir! \n {model.Name} \n {model.Price} \n {model.Stock} ");
    }
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [HttpPut("UpdateProduct")]
    public async Task<IActionResult> UpdateProduct([FromForm] UpdateProductVm model)
    {
        if (await _productService.AnyAsync(x => x.ProductName == model.Name && x.ProductCode != model.ProductCode))
            return BadRequest("Bu isim kullanılmaktadır. Başka bir isim seçiniz!");
        if (!await _productService.AnyAsync(x => x.ProductCode == model.ProductCode && x.Status != Status.Passive))
            return NotFound("Bu id'ye sahip bir kategori bulunamadı!");
        var entity = await _productService.GetByIdAsync<UpdateProductDto>(c=>c.ProductCode == model.ProductCode);
        entity.ProductName = model.Name;
        entity.ProductPrice=model.ProductPrice;
        entity.Stock = model.Stock; 
        entity.UpdatedDate = DateTime.Now;
        entity.CategoryCode = model.CategoryCode;
        var result = await _productService.UpdateAsync(entity);
        if(result)
            return Ok($"Ürün güncellenmiştir!\nKategori Bilgileri: \n {model.Name} \n {model.ProductPrice} \n {model.Stock} \n {model.CategoryCode}");
        return BadRequest("Güncelleme sırasında bir sorun oluştu");
    }
    [HttpDelete("DeleteProduct")]
    public async Task<IActionResult> DeleteProduct(Int64 id)
    {
        if (id <= 0)
            return BadRequest("Bi şeyler ters gitti!");
        var product = await _productService.GetByIdAsync<DeleteProductDto>(c=>c.ProductCode==id);
        
        if (product is null)
            return NotFound("Ürün bulunamadı!!");
        
        await _productService.DeleteAsync(product);
        
        return Ok("Ürün silinmiştir!!");

        
    }
}