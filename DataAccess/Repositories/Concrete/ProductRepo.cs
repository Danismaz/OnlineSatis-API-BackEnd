using DataAccess.Context.ApplicationContext;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace DataAccess.Repositories.Concrete;

public class ProductRepo(AppDbContext context) : BaseRepository<Product>(context),IProductRepo
{
    
}