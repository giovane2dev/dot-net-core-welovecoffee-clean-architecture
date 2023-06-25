using Microsoft.EntityFrameworkCore;
using PromoBeta.Domain.Entities;

namespace PromoBeta.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        // constructs and transfer database context options for base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // used to query and save instances of entity
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set;  }        

        // 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}