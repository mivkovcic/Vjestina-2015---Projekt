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
    
    public partial class Natjecatelj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Natjecatelj()
        {
            this.DogađajNatjecatelj = new HashSet<DogađajNatjecatelj>();
        }
    
        public int pk_natjecatelj { get; set; }
        public string naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogađajNatjecatelj> DogađajNatjecatelj { get; set; }
    }
}
