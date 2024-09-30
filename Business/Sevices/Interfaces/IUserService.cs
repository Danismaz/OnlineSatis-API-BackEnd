using DataAccess.Repositories.Interfaces;
using Entities.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Sevices.Interfaces
{
    public interface IUserService : IBaseService<IUserRepo,User>
    {
    }
}
