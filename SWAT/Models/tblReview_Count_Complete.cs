//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWAT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblReview_Count_Complete
    {
        public int ReviewerID { get; set; }
        public int TERM { get; set; }
        public Nullable<int> PROGRAM { get; set; }
        public Nullable<int> COMPLETE { get; set; }
        public Nullable<int> INCOMPLETE { get; set; }
        public Nullable<int> total { get; set; }
        public Nullable<double> AVERAGE { get; set; }
        public Nullable<double> SCORE_STDEV { get; set; }
        public Nullable<double> SCORE_MEDIAN { get; set; }
    }
}
