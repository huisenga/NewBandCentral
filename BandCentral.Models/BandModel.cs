using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Model
{
    public class Band
    {
        public  int ID { get; set; }
        public string BandName { get; set; }

        public virtual List<ApplicationUser> User { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public Band()
        {
            DateCreated = DateTime.Now;
        }
    }
}
