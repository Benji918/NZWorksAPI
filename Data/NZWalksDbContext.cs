using Microsoft.EntityFrameworkCore;
using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Work> Works { get; set; }
    }

}
