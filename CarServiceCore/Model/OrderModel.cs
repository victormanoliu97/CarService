using System;

namespace CarServiceCore.Model
{
    public class OrderModel
    {
        public int ComandaId { get; set; }
        public int AutoId { get; set; }
        public int ClientId { get; set; }
        public string StareComanda { get; set; }
        public System.DateTime DataSystem { get; set; }
        public Nullable<System.DateTime> DataProgramare { get; set; }
        public Nullable<System.DateTime> DataFinalizare { get; set; }
        public int KmBord { get; set; }
        public string Descriere { get; set; }
        public decimal ValoarePiese { get; set; }
        public string NumarAuto { get; set; }
    }
}