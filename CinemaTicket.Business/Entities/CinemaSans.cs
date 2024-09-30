using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class CinamaSanse
    {
        public string CinemaName { get; set; }
        public int CinemaId { get; set; }
        public int SanseId { get; set; }
        public DateTime ShowTime { get; set; }
        public int SalonId { get; set; }
    }
}
