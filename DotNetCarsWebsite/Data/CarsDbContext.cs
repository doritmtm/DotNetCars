
using DotNetCarsWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCarsWebsite.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
