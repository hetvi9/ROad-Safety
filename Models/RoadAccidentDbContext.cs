using Microsoft.EntityFrameworkCore;

namespace RodeSafetyTool.Models
{
    public class RoadAccidentDbContext :DbContext
    {
        public RoadAccidentDbContext(DbContextOptions<RoadAccidentDbContext> options) :base(options)
        {

        }
        public DbSet<RoadAccident> RoadAccidents { get;set; }
    }
}
