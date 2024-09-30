using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using CinemaTicket.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services
{
    public class UserService : BaseService<User, IUserRepo>, IUserService
    {
        public UserService(IUserRepo repo) : base(repo)
        {
        }

        public bool IsUserExists(int id)
        {
            return _repo.IsUserExists(id);
        }
    }
}
