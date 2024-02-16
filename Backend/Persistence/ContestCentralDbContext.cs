using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class ContestCentralDbContext : IdentityDbContext<ApplicationUser>
{
        public ContestCentralDbContext(DbContextOptions<ContestCentralDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ContestCentralDbContext).Assembly);
        }
    
}