using Microsoft.EntityFrameworkCore;
using PromoBeta.Domain.Entities;

namespace PromoBeta.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // defines entities (POCO class) for mapping according to code first approach
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set;  }
        public DbSet<Company> Companies { get; set; }

        // method override for contextualization using fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}