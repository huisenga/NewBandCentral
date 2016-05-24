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
        public long Id { get; set; }
        [Display(Name = "Band Name")]
        public string BandName { get; set; }
        public bool isFavorited { get; set; }
    }
    public class DetailsBandViewModel
    {
        [Display(Name = "Band ID")]
        public long Id { get; set; }
        [Display(Name = "Band Name")]
        public string BandName { get; set; }

        [Display(Name = "Created")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Updated")]
        public DateTime UpdatedDate { get; set; }
    }
}