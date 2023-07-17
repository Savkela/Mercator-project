using MercatorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MercatorApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        public DbSet<Match> Mathes { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
