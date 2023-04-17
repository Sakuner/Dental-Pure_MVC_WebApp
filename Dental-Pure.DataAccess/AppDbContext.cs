//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Dental_Pure_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Dental_Pure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ReservationModel> Reservations { get; set; }
        public DbSet<StaffModel> StaffEmployee { get; set; }
    }
}