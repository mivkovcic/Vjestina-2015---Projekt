//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportEvents.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Rezervacija
    {
        [Key]
        public int pk_rezervacija { get; set; }
        public int fk_korisnik { get; set; }
        public int fk_događaj { get; set; }
        public Nullable<short> broj_karata { get; set; }
    
        public virtual Događaj Događaj { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}