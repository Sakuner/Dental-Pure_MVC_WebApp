using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dental_Pure.DataAccess
{
    public class DbContext : IdentityDbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }


    }
}