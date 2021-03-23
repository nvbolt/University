using Microsoft.EntityFrameworkCore;
using University.DomainLayer.Entities;

namespace University.DataLayer
{
    public class VuDbContext :DbContext
    {
        public VuDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VuDbContext).Assembly);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}