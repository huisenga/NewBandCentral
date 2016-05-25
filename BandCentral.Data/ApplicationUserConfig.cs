using BandCentral.Model;
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
