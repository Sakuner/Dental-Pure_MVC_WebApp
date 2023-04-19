using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dental_Pure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class staffToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StaffEmployee",
                columns: new[] { "Id", "Description", "Name", "PhotoUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Specializes in oral and maxillofacial Surgery", "Jean Chan", "\\images\\staff\\doctor1.png", "Doctor of Dental Surgery" },
                    { 2, "Specializes in orthodontology", "Kate Smith", "\\images\\staff\\doctor2.png", "Doctor of Dental Medicine" },
                    { 3, "Specializes in cosmetic and general dentistry", "George Michael", "\\images\\staff\\doctor3.png", "Doctor of Dental Medicine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StaffEmployee",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
