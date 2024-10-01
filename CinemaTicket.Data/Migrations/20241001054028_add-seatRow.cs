using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaTicket.Data.Migrations
{
    public partial class addseatRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatRow",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatRow",
                table: "Seats");
        }
    }
}
