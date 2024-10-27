using DataAccess.Context.ApplicationContext;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace DataAccess.Repositories.Concrete;

public class OrderDetailRepo (AppDbContext context) : BaseRepository<OrderDetail>(context),IOrderDetailRepo
{
    
}