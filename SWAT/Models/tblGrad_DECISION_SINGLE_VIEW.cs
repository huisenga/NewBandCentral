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
    
    public partial class tblGrad_DECISION_SINGLE_VIEW
    {
        public double ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string ACAD_CAREER { get; set; }
        public int ADM_APPL_NBR { get; set; }
        public decimal APPL_PROG_NBR { get; set; }
        public System.DateTime EFFECTIVE_DATE { get; set; }
        public decimal EFFECTIVE_SEQ { get; set; }
        public string ACAD_PROG { get; set; }
        public string PROG_ACTION { get; set; }
        public Nullable<System.DateTime> ACTION_DATE { get; set; }
        public string PROG_REASON { get; set; }
        public string PROG_REASON_DESCR { get; set; }
        public Nullable<int> ADMIT_TERM { get; set; }
        public string REQ_TERM { get; set; }
        public Nullable<System.DateTime> LOADDATE { get; set; }
        public Nullable<long> rankOrder { get; set; }
    }
}
