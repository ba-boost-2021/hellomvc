using BilgeAdam.BootStrap.Models;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.BootStrap.Context
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
