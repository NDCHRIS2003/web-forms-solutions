//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INLANDMARINA.MARINA.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Slip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Slip()
        {
            this.Leases = new HashSet<Lease>();
        }
    
        public int ID { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int DockID { get; set; }
    
        public virtual Dock Dock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lease> Leases { get; set; }
    }
}
