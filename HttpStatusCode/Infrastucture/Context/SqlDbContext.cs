using HttpStatusCode.Infrastucture.SeedData;
using HttpStatusCode.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HttpStatusCode.Infrastucture.Context
{
    public class SqlDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public SqlDbContext()
        {

        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Database=WepApiDb;User Id=sa;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorySeedData());

        }

    }
}
