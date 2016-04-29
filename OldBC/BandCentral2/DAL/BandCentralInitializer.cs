using BandCentral.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BandCentral.DAL
{

    public class BandCentralInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BandCentralContext>
    {
        protected override void Seed(BandCentralContext context)
        {
            var users = new List<User>
                {
                    new User {FirstName="Bret",LastName="Huisenga", Email="huisenga@wisc.edu" },
                    new User {FirstName="Ashley",LastName="Huisenga", Email="huisenga@wisc.edu" },
                    new User {FirstName="Cooper",LastName="Huisenga", Email="huisenga@wisc.edu" },
                    new User {FirstName="Timmy",LastName="Test", Email="huisenga@wisc.edu" }
                };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var bands = new List<Band>
                {
                    new Band {BandName ="Beatles" },
                    new Band {BandName ="The Who" },
                    new Band {BandName ="Led Zeplin" },
                    new Band {BandName ="Pink Floyd" },
                    new Band {BandName ="Boston" }
                };
            bands.ForEach(s => context.Bands.Add(s));
            context.SaveChanges();
        }
    }
}
