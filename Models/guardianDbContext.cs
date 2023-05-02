using Microsoft.EntityFrameworkCore;

namespace RodeSafetyTool.Models
{
    public class guardianDbContext : DbContext
    {
        public guardianDbContext(DbContextOptions<guardianDbContext> options) : base(options)
        {

        }
        public DbSet<guardian> guardians { get; set; }
    }
}
