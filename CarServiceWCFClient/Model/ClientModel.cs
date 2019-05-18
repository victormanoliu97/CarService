using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceWCFClient.Model
{
    public class ClientModel
    {
        public ClientModel()
        {
            this.Automobils = new HashSet<Automobil>();
            this.Comandas = new HashSet<Comanda>();
        }
    
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automobil> Automobils { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comanda> Comandas { get; set; }

        public override string ToString()
        {
            return Nume + " " + Prenume + " " + Adresa + " " + Localitate + " " + Judet + " " + Telefon + " " + Email;
        }
    }
}