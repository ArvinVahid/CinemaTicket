using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services.Interfaces
{
    public interface ICinemaService : IBaseService<Cinema>
    {
        Cinema GetCinemaByName(string name);
        bool IsCinemaExists(int id);
    }
}
