using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using BandCentral.Model;
using BandCentral.Data;
using System.Data.Entity.ModelConfiguration;

namespace BandCentral
{
    public class ApplicationUserConfig : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfig()
        {
            ToTable("Users")
            .HasMany(b => b.Bands)
            .WithMany(r => r.Users)
            .Map(mc =>
            {
                mc.MapLeftKey("UserID");
                mc.MapRightKey("BandID");
                mc.ToTable("UserBands");
            });
            Property(g => g.FirstName).IsRequired().HasMaxLength(50);
            Property(g => g.LastName).IsRequired().HasMaxLength(50);
        }
    }
}
