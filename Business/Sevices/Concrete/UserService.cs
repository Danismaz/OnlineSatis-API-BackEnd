using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using Entities.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Sevices.Concrete
{
    public class UserService : BaseService<IUserRepo, User>, IUserService
    {
        public UserService(IUserRepo repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
