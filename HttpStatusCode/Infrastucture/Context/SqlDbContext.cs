using HttpStatusCode.Infrastucture.SeedData;
using HttpStatusCode.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HttpStatusCode.Infrastucture.Context
{
    public class SqlDbContext : DbContext
    {

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }

        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategorySeedData());

        }

    }
}
