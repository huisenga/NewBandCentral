using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BandCentral.Models
{
    public class Band
    {
        public int ID { get; set; }

        [Required]
        public string BandName { get; set; }
    }
}