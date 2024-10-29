using AutoMapper;
using Business.ActionFilters;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using Entities.Consts;
using KYSProjectApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Categories;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;
    public CategoriesController(ICategoryService categoryService,IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet("GetAllCategory")]
    public async Task<IActionResult> GetAllCategory()
    {
        var categories = await _categoryService.GetFilteredListAsync
            (
            select: x => new GetAllCategoryDto
            {
                CategoryCode = x.CategoryCode,
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                Status = x.Status,
            },
            where: x => x.Status != Status.Passive,
            orderBy: x => x.OrderByDescending(z => z.CreatedDate)
            );
        return Ok(categories);
    }
    [HttpGet("GetCategoryById")]
    public async Task<IActionResult> GetCategoryById(Int64 id)
    {
        var category = await _categoryService.GetByIdAsync<GetAllCategoryDto>(c => c.CategoryCode == id);
        if (category == null)
        {
            return NotFound("Kategori bulunamadı.");
        }

        // Category nesnesini GetAllCategoryDto'ya dönüştürme
        var categoryDto = _mapper.Map<GetAllCategoryDto>(category);

        return Ok(categoryDto);
    }
    [HttpPost("CreateCategory")]
    public async Task<IActionResult> CreateCategory([FromForm] CreateCategoryVm model)
    {
        if (model == null)
            return BadRequest("Bir şeyler ters gitti!");

        if (await _categoryService.AnyAsync(x => x.CategoryName == model.Name))
            return BadRequest("Bu isimde bir kategori var. Farklı bir isim seçiniz!");

        var dto = new CreateCategoryDto
        {
            CategoryName = model.Name,
            CategoryDescription = model.Description,
            CreatedDate = DateTime.Now,
            Status = Status.Active
        };
        
        var result = await _categoryService.AddAsync(dto);

        if (result is false)
        {
            return BadRequest("İşlem yapılırken bir sorun oluştu.");
        }

        return Ok($"Kategori eklenmiştir! \n{model.Name}\n{model.Description}");
    }
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [HttpPut("UpdateCategory")]
    public async Task<IActionResult> UpdateCategory([FromForm] UpdateCategoryVm model)
    {

        if (await _categoryService.AnyAsync(x => x.CategoryName == model.CategoryName && x.CategoryCode != model.CategoryCode))
            return BadRequest("Bu isim kullanılmaktadır. Başka bir isim seçiniz!");

        if (!await _categoryService.AnyAsync(x => x.CategoryCode == model.CategoryCode && x.Status != Status.Passive))
            return NotFound("Bu id'ye sahip bir kategori bulunamadı!");

        var entity = await _categoryService.GetByIdAsync<UpdateCategoryDto>(c => c.CategoryCode == model.CategoryCode);

        entity.CategoryName = model.CategoryName;
        entity.CategoryDescription = model.CategoryDescription;
        entity.UpdatedDate = DateTime.Now;
        
       var result= await _categoryService.UpdateAsync(entity);
        if(result)
            return Ok($"Kategori güncellenmiştir!\nKategori Bilgileri: \n{entity.CategoryName}\n{entity.CategoryDescription}");
        return BadRequest("Güncelleme sırasında bir sorun oluştu");
    }
    [HttpDelete("DeleteCategory")]
    public async Task<IActionResult> DeleteCategory(Int64 id)
    {
        if (id <= 0)
            return BadRequest("Bi şeyler ters gitti!");

        var category = await _categoryService.GetByIdAsync<GetAllCategoryDto>(c => c.CategoryCode == id);

        if (category is null)
            return NotFound("Kategori bulunamadı!");

        await _categoryService.DeleteAsync(category);
        return Ok("Kategori silinmiştir!");
    }
}