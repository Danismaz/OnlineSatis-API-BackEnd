using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Concrete;

public class CategoryService(ICategoryRepo repository, IMapper mapper) : BaseService<ICategoryRepo , Category>(repository,mapper),ICategoryService
{
    
}