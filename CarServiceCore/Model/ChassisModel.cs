namespace CarServiceCore.Model
{
    public class ChassisModel
    {
        public int SasiuId { get; set; }
        public string CodSasiu { get; set; }
        public string Denumire { get; set; }

        public override string ToString()
        {
            return CodSasiu + " " + Denumire;
        }
    }
}