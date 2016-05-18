using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BandCentral.ViewModels
{
    public class BandViewModel
    {
        [Display(Name="Band ID")]
        public int ID { get; set; }
        [Display(Name = "Band Name")]
        public string BandName { get; set; }
        public bool isFavorited { get; set; }
    }
}