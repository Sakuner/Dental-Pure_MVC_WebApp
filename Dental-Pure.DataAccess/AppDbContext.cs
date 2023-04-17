﻿//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
                new ServiceModel { Id = 1, Name = "Dental examination", Price = 0},
                new ServiceModel { Id = 2, Name = "Dental surgery", Price = 100 },
                new ServiceModel { Id = 3, Name = "Fluoridation of teeth", Price = 90 },
                new ServiceModel { Id = 4, Name = "Prosthodontic consultation", Price = 0 },
                new ServiceModel { Id = 5, Name = "Teeth sealing", Price = 80 },
                new ServiceModel { Id = 6, Name = "Treatment of dental caries", Price = 70 },
                new ServiceModel { Id = 7, Name = "Denture repair", Price = 200 },
                new ServiceModel { Id = 8, Name = "Teeth restoration", Price = 150 },
                new ServiceModel { Id = 9, Name = "Dentures", Price = 750 },
                new ServiceModel { Id = 10, Name = "Tartar removal", Price = 140 },
                new ServiceModel { Id = 11, Name = "Teeth removal", Price = 100 },
                new ServiceModel { Id = 12, Name = "Composite filling", Price = 80 },
                new ServiceModel { Id = 13, Name = "Gum excision", Price = 100 }
                );
        }
    }
}