using DataAccess.Context.ApplicationContext;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace DataAccess.Repositories.Concrete;

public class ShipperRepo(AppDbContext context) : BaseRepository<Shipper>(context),IShipperRepo
{
    
}