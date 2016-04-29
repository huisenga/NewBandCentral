using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BandCentral.Models
{
    public class Band
    {
        public int BandID { get; set; }

        public string BandName { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}