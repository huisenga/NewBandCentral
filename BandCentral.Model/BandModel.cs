using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandCentral.Model;

namespace BandCentral.Model
{
    public class Band: AuditableEntity<long>
    {

        [Required]
        public string BandName { get; set; }

        public virtual List<ApplicationUser> Users { get; set; }

    }
}
