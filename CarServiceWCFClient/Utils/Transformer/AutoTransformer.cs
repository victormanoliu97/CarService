using CarServiceCore.Context;

namespace CarServiceWCFClient.Utils.Transformer
{
    public abstract class AutoTransformer
    {
        public static void MergeAutoEntities(Automobil dbAuto, Automobil foundAuto)
        {
            dbAuto.AutoId = foundAuto.AutoId;
            dbAuto.SasiuId = foundAuto.SasiuId;
            dbAuto.SerieSasiu = foundAuto.SerieSasiu;
            dbAuto.ClientId = foundAuto.ClientId;
            dbAuto.NumarAuto = foundAuto.NumarAuto;
        }
    }
}