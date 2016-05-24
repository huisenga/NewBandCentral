using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandCentral.Model
{
    public class Band
    {
        [Key]
        public  int ID { get; set; }
        [Required]
        public string BandName { get; set; }

        public virtual List<ApplicationUser> Users { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public Band()
        {
            DateCreated = DateTime.Now;
        }
    }
}
