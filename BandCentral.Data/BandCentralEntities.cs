using BandCentral.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Band> Bands { get; set; }

        //public DbSet<ApplicationUser> Users { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("Users");
            
            //Custom Application User Congigs
            modelBuilder.Configurations.Add(new ApplicationUserConfig());
            
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("Userclaims");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("Userlogins");

            //Add model for Bands
            modelBuilder.Configurations.Add(new BandConfig());

        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
