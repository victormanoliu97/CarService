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
    
    public partial class Mecanic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mecanic()
        {
            this.DetaliiComandas = new HashSet<DetaliiComanda>();
        }
    
        public int MecanicId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetaliiComanda> DetaliiComandas { get; set; }
    }
}
