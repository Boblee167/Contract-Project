using ContractManager.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContractManager.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("ApplicationDbContext")
        {
        }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<ContractDetail> ContractDetails { get; set; }
        public DbSet<ContractHour> ContractHours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

