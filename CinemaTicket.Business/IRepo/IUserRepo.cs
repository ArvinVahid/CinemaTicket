using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.IRepo
{
    public interface IUserRepo : IBaseRepo<User>
    {
        bool IsUserExists(int id);
    }
}
