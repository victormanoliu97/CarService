using CarServiceCore.Context;

namespace CarServiceWCFClient.Utils.Transformer
{
    public abstract class ChassisTransformer
    {
        public static void MergeChassisEntities(Sasiu dbChassis, Sasiu foundChassis)
        {
            dbChassis.CodSasiu = foundChassis.CodSasiu;
            dbChassis.Denumire = foundChassis.Denumire;
        }
    }
}