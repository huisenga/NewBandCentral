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
    
    public partial class tblAffAgreement
    {
        public int AAID { get; set; }
        public Nullable<int> OrgID { get; set; }
        public Nullable<System.DateTime> AgencySendDate { get; set; }
        public Nullable<System.DateTime> AgencyReturnDate { get; set; }
        public Nullable<System.DateTime> DirectorSignDate { get; set; }
        public Nullable<System.DateTime> VChanSendDate { get; set; }
        public Nullable<System.DateTime> VChanReturnDate { get; set; }
        public Nullable<System.DateTime> AAEnterDate { get; set; }
        public string AANotes { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<System.DateTime> AAAdded { get; set; }
        public Nullable<System.DateTime> AAEdited { get; set; }
    }
}
