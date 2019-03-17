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
    
    public partial class DetaliiComanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetaliiComanda()
        {
            this.Comandas = new HashSet<Comanda>();
            this.Imagines = new HashSet<Imagine>();
        }
    
        public int DetaliiComandaId { get; set; }
        public int ComandaId { get; set; }
        public int AutoId { get; set; }
        public int MecanicId { get; set; }
        public int OperatieId { get; set; }
        public int ImagineId { get; set; }
    
        public virtual Automobil Automobil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comanda> Comandas { get; set; }
        public virtual Comanda Comanda { get; set; }
        public virtual Imagine Imagine { get; set; }
        public virtual Mecanic Mecanic { get; set; }
        public virtual Operatie Operatie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imagine> Imagines { get; set; }
    }
}
