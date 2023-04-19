using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dental_Pure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class photosUrlFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "\\images\\staff\\doctor1.png");

            migrationBuilder.UpdateData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "\\images\\staff\\doctor2.png");

            migrationBuilder.UpdateData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "\\images\\staff\\doctor3.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "\\images\\staff\\doctor1");

            migrationBuilder.UpdateData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "\\images\\staff\\doctor2");

            migrationBuilder.UpdateData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "\\images\\staff\\doctor3");
        }
    }
}
