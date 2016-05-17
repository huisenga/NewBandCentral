using BandCentral.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
