//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Dental_Pure.Entities;
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
        public DbSet<ServiceModel> Services { get; set; }


        //seeding the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceModel>().HasData(
                new ServiceModel { Id = 1, Name = "", Price = 1}
                
                
                );
        }
    }
}