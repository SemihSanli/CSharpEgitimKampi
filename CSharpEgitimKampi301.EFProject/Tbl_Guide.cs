//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Guide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Guide()
        {
            this.Tbl_Location = new HashSet<Tbl_Location>();
        }
    
        public int guideId { get; set; }
        public string guideName { get; set; }
        public string guideSurname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Location> Tbl_Location { get; set; }
    }
}
