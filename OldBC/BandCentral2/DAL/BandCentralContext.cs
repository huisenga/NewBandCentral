using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BandCentral.Models;

namespace BandCentral.DAL
{
    public class BandCentralContext : DbContext
    {
        public BandCentralContext() : base("BandCentralContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Band> Bands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}