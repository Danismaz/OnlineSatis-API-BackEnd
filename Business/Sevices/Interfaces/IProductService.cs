using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Interfaces;

public interface IProductService : IBaseService<IProductRepo, Product>
{
    
}