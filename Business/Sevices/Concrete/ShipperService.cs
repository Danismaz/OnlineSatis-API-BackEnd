using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace Business.Sevices.Concrete;

public class ShipperService (IShipperRepo repository, IMapper mapper) : BaseService<IShipperRepo, Shipper>(repository, mapper), IShipperService
{
    
}