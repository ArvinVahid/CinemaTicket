﻿using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using CinemaTicket.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services
{
    public class ReservationService : BaseService<Reservation, IReservationRepo>, IReservationService
    {
        public ReservationService(IReservationRepo repo) : base(repo)
        {
        }
    }
}
