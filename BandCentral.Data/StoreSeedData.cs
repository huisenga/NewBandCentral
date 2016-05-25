using BandCentral.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace BandCentral.Data
{
    public class StoreSeedData : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            GetBands().ForEach(b => context.Bands.Add(b));
            context.SaveChanges();
        }

        private static List<Band> GetBands()
        {
            return new List<Band>
            {
                new Band
                {
                    BandName = "Pink Floyd"
                },
                new Band
                {
                    BandName = "The Who"
                },
                new Band
                {
                    BandName = "The Beatles"
                },
                new Band
                {
                    BandName = "Led Zeppelin"
                },
                new Band
                {
                    BandName = "The Rolling Stones"
                },
                new Band
                {
                    BandName = "Eagles"
                }
            };
        }
    }
}
