using Microsoft.EntityFrameworkCore;
using MarinePollutionApi.Models;


namespace MarinePollutionApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PollutionRecords> PollutionRecords { get; set; }
    }
}
