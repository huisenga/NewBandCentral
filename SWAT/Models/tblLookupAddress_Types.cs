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
    
    public partial class tblLookupAddress_Types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLookupAddress_Types()
        {
            this.tblSTDNT_Address = new HashSet<tblSTDNT_Address>();
        }
    
        public int AddrTypeID { get; set; }
        public string AddrTypeDesc { get; set; }
    
        public virtual tblLookupAddress_Types tblLookupAddress_Types1 { get; set; }
        public virtual tblLookupAddress_Types tblLookupAddress_Types2 { get; set; }
        public virtual tblLookupAddress_Types tblLookupAddress_Types11 { get; set; }
        public virtual tblLookupAddress_Types tblLookupAddress_Types3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSTDNT_Address> tblSTDNT_Address { get; set; }
    }
}
