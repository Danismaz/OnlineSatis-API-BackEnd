using DataAccess.Context.ApplicationContext;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace DataAccess.Repositories.Concrete;

public class OrderRepo (AppDbContext context) : BaseRepository<Order>(context),IOrderRepo
{
    
}