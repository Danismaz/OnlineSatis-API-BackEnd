using DataAccess.Context.ApplicationContext;
using DataAccess.Repositories.Interfaces;
using Entities.Entites.Concrete;

namespace DataAccess.Repositories.Concrete;

public class UserDetailRepo : BaseRepository<UserDetail>,IUserDetailRepo
{
    public UserDetailRepo(AppDbContext context) : base(context)
    {
    }
}