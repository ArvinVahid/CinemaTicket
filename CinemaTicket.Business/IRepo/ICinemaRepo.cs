using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.IRepo
{
    public interface ICinemaRepo : IBaseRepo<Cinema>
    {
        Cinema GetCinemaByName(string name);
        bool IsCinemaExists(int id);
    }
}
