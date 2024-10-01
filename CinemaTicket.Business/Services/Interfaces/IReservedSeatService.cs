using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services.Interfaces
{
    public interface IReservedSeatService : IBaseService<ReservedSeat>
    {
        void InsertListOfReservedSeats(List<ReservedSeat> seats);
    }
}
