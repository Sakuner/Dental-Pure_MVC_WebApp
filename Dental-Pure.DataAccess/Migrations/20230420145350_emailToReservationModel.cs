using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dental_Pure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class emailToReservationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reservations");
        }
    }
}
