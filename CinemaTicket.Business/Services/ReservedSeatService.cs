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
    public class ReservedSeatService : BaseService<ReservedSeat, IReservedSeatRepo>, IReservedSeatService
    {
        public ReservedSeatService(IReservedSeatRepo repo) : base(repo)
        {
        }

        public void InsertListOfReservedSeats(List<ReservedSeat> seats)
        {
            foreach (ReservedSeat seat in seats)
            {
                _repo.Insert(seat);
            }
        }
    }
}
