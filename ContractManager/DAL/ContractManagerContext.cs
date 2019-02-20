using ContractManager.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContractManager.DAL
{
    public class ContractManagerContext : IdentityDbContext<ApplicationUser>
    {
        public ContractManagerContext() : base("ContractManagerContext")
        {
        }

        public DbSet<Supplier> CMSupplier { get; set; }
        public DbSet<Property> CMProperty { get; set; }
        public DbSet<ContractDetails> CMContract { get; set; }
        public DbSet<ContractHours> CMCleaningHours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

