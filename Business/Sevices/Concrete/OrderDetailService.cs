using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Concrete;

public class OrderDetailService (IOrderDetailRepo repository, IMapper mapper) : BaseService<IOrderDetailRepo, OrderDetail>(repository, mapper), IOrderDetailService
{
    
}