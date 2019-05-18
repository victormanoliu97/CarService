namespace CarServiceWCFClient.Model
{
    public class AutoModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutoModel()
        {
            
        }
    
        public int AutoId { get; set; }
        public int ClientId { get; set; }
        public string NumarAuto { get; set; }
        public int SasiuId { get; set; }
        public string SerieSasiu { get; set; }

        public override string ToString()
        {
            return NumarAuto + " " + SerieSasiu;
        }
    }
}