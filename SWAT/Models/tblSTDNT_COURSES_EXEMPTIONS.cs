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
    
    public partial class tblSTDNT_COURSES_EXEMPTIONS
    {
        public int EID { get; set; }
        public Nullable<int> ID { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string CATALOG_NUMBER { get; set; }
        public Nullable<int> EXEMPTION_TYPE { get; set; }
        public Nullable<int> WarrantCredits { get; set; }
    
        public virtual tblSTDNT_LOCAL tblSTDNT_LOCAL { get; set; }
    }
}
