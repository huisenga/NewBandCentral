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
    
    public partial class tblWorkLocation
    {
        public int ID { get; set; }
        public int FCID { get; set; }
        public int OrgID { get; set; }
        public Nullable<System.DateTime> JoinAdded { get; set; }
        public string JoinNotes { get; set; }
        public Nullable<int> OrgStatusID { get; set; }
        public string OtherStatus { get; set; }
        public string WorkingTitle { get; set; }
        public bool MainAgencyContact { get; set; }
        public byte[] upsize_ts { get; set; }
    
        public virtual tblFieldContact tblFieldContact { get; set; }
    }
}
