using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data.Repo
{
    public class SeatRepo : BaseRepo<Seat>, ISeatRepo
    {
        public SeatRepo(DataContext context) : base(context)
        {
        }

        public bool IsSeatExists(int id)
        {
            return Query.Any<Seat>(x => x.Id == id);
        }
    }
}
