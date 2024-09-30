using CinemaTicket.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CinemaToMovie>().HasNoKey();

            //modelBuilder.Entity<ReservedSeat>().HasMany("SeatId").WithOne().OnDelete(DeleteBehavior.NoAction);

            #region Seed Data

            modelBuilder.Entity<Cinema>().HasData(
                new Cinema
                {
                    Id = 1,
                    Name = "Azadi",
                    Address = "Tehran azadi",
                    Rate = 3,

                },
                new Cinema
                {
                    Id = 2,
                    Name = "Kourosh",
                    Address = "Tehran Sattari",
                    Rate = 4,

                });

            modelBuilder.Entity<Salon>().HasData(
                new Salon
                {
                    Id = 1,
                    Name = "Salon 1",
                    Capacity = 200,
                    CinemaId = 1

                },
                new Salon
                {
                    Id = 2,
                    Name = "Salon 1",
                    Capacity = 300,
                    CinemaId = 2
                },
                new Salon
                {
                    Id = 3,
                    Name = "Salon 2",
                    Capacity = 100,
                    CinemaId = 2
                },
                new Salon
                {
                    Id = 4,
                    Name = "Salon 3",
                    Capacity = 300,
                    CinemaId = 2
                });

            #endregion
        }

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<CinemaToMovie> CinemaToMovies { get; set; }
        public DbSet<ShowTime> ShowTimes { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<ReservedSeat> ReservedSeats { get; set; }

    }
}
