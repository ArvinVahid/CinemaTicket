using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class Seat : BaseEntity
    {
        public int SeatNumber { get; set; }
        public int SalonId { get; set; }

        public Salon Salon { get; set; }
    }
}
