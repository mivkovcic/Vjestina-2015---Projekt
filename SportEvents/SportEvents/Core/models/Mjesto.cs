//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportEvents.Core.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mjesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mjesto()
        {
            this.Događaj = new HashSet<Događaj>();
        }
    
        public int pk_mjesto { get; set; }
        public int fk_grad { get; set; }
        public Nullable<int> fk_tip { get; set; }
        public string naziv { get; set; }
        public Nullable<short> kapacitet { get; set; }
        public string adresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Događaj> Događaj { get; set; }
        public virtual Grad Grad { get; set; }
        public virtual Tip Tip { get; set; }
    }
}
