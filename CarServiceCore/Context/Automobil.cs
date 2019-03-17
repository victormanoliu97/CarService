//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServiceCore.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Automobil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Automobil()
        {
            this.Comandas = new HashSet<Comanda>();
            this.DetaliiComandas = new HashSet<DetaliiComanda>();
        }
    
        public int AutoId { get; set; }
        public int ClientId { get; set; }
        public string NumarAuto { get; set; }
        public int SasiuId { get; set; }
        public string SerieSasiu { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Sasiu Sasiu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comanda> Comandas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetaliiComanda> DetaliiComandas { get; set; }
    }
}
