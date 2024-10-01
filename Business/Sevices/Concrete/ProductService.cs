using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Concrete;

public class ProductService(IProductRepo repository, IMapper mapper) : BaseService<IProductRepo, Product>(repository, mapper), IProductService
{
    
}