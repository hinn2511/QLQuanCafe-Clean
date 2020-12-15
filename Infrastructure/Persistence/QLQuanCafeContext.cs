using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;
using Domain.Entities;
using Domain.Entities.CustomerAggregate;
using Domain.Entities.BillAggregate;

namespace Infrastructure.Persistence
{
    public class QLQuanCafeContext : IdentityDbContext
    {
        public QLQuanCafeContext(DbContextOptions<QLQuanCafeContext> options) : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Product> Products{ get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());    
          

        }

    }

    
}