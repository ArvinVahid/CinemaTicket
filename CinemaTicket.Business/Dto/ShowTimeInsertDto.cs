using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Dto
{
    public class ShowTimeInsertDto
    {
        public int MovieId { get; set; }
        public int SalonId { get; set; }
        public DateTime ShowingTime { get; set; }
        public decimal Price { get; set; }
    }
}
