using CinemaTicket.Business.IRepo;
using CinemaTicket.Business.Services;
using CinemaTicket.Business.Services.Interfaces;
using CinemaTicket.Data;
using CinemaTicket.Data.Repo;
using Microsoft.EntityFrameworkCore;

namespace CinemaTicket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<ICinemaService, CinemaService>();
            builder.Services.AddScoped<ICinemaRepo, CinemaRepo>();

            builder.Services.AddScoped<IMovieRepo, MovieRepo>();
            builder.Services.AddScoped<IMovieService, MovieService>();

            builder.Services.AddScoped<IShowTimeService, ShowTimeService>();
            builder.Services.AddScoped<IShowTimeRepo, ShowTimeRepo>();

            builder.Services.AddScoped<IUserRepo, UserRepo>();
            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddScoped<IReservationService, ReservationService>();
            builder.Services.AddScoped<IReservationRepo, ReservationRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}