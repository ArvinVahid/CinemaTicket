using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class Reservation : BaseEntity
    {
        public int UserId { get; set; }
        public int ShowTimeId { get; set; }
        public int NumberOfTickets { get; set; }
        public DateTime ReservationDate { get; set; }
        public decimal TotalPrice { get; set; }

        public User User { get; set; }
        public ShowTime ShowTime { get; set; }
        public ICollection<ReservedSeat> ReservedSeats { get; set; }

    }
}
