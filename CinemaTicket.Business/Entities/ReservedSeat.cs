using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class ReservedSeat : BaseEntity
    {
        public int ReservationId { get; set; }
        public int? SeatId { get; set; }

        public Reservation Reservation { get; set; }
        public Seat Seat{ get; set; }
    }
}
