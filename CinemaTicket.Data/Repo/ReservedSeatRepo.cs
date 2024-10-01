using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data.Repo
{
    public class ReservedSeatRepo : BaseRepo<ReservedSeat>, IReservedSeatRepo
    {
        public ReservedSeatRepo(DataContext context) : base(context)
        {
        }
    }
}
