using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data.Repo
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public UserRepo(DataContext context) : base(context)
        {
        }

        public bool IsUserExists(int id)
        {
            return Query.Any(u => u.Id == id);
        }
    }
}
