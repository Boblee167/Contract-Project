
/*using ContractManager.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContractManager.DAL
{
    public class ContractManagerContext : IdentityDbContext<ApplicationUser>
    {
        public ContractManagerContext() : base("ContractManagerContext")
        {
        }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<ContractDetails> ContractDetails { get; set; }
        public DbSet<ContractHours> ContractHours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
*/

