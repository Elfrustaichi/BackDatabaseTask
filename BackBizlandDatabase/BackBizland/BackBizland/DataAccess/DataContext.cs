using BackBizland.Models;
using Microsoft.EntityFrameworkCore;

namespace BackBizland.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<Service> Services { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set;}

    }
}
