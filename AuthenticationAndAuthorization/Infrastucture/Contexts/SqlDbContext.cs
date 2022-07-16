using AuthenticationAndAuthorization.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Infrastucture.Contexts
{
    public class SqlDbContext : IdentityDbContext<AppUser>
    {

        public SqlDbContext()
        {

        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }

    }
}
