using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Concrete;

public class OrderService (IOrderRepo repository, IMapper mapper) : BaseService<IOrderRepo, Order>(repository, mapper), IOrderService
{
    
}