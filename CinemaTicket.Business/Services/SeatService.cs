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
    public class SeatService : BaseService<Seat, ISeatRepo>, ISeatService
    {
        public SeatService(ISeatRepo repo) : base(repo)
        {
        }

        public bool IsSeatExists(int id)
        {
            return _repo.IsSeatExists(id);
        }
    }
}
