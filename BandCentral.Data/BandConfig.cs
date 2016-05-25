using BandCentral.Model;
using System.Data.Entity.ModelConfiguration;

namespace BandCentral.Data
{
    public class BandConfig: EntityTypeConfiguration<Band>
    {
        public BandConfig()
        {
            ToTable("Bands");
            Property(g => g.BandName).IsRequired().HasMaxLength(100);
        }
    }
}
