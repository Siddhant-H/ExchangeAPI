
using ExchangeAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ExchangeAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<exchangerates> exchangerates { get; set; }
    }
}
