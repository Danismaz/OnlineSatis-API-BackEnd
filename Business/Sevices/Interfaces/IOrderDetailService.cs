using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Interfaces;

public interface IOrderDetailService : IBaseService<IOrderDetailRepo,OrderDetail>
{
    
}