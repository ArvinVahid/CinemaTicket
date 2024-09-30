using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaTicket.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Salon 1");

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Capacity", "CinemaId", "Name" },
                values: new object[] { 3, 100, 2, "Salon 2" });

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Capacity", "CinemaId", "Name" },
                values: new object[] { 4, 300, 2, "Salon 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Salon 2");
        }
    }
}
