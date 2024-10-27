using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Interfaces;

public interface IOrderService : IBaseService<IOrderRepo,Order>
{
    
}