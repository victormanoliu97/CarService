using CarServiceCore.Context;

namespace CarServiceCore.Utils.Transformer
{
    public abstract class AutoTransformer
    {
        public static void MergeAutoEntities(Automobil dbAuto, Automobil foundAuto)
        {
            dbAuto.AutoId = foundAuto.AutoId;
            dbAuto.Client = foundAuto.Client;
            dbAuto.Sasiu = foundAuto.Sasiu;
            dbAuto.Comandas = foundAuto.Comandas;
            dbAuto.SasiuId = foundAuto.SasiuId;
            dbAuto.ClientId = foundAuto.ClientId;
            dbAuto.NumarAuto = foundAuto.NumarAuto;
            dbAuto.DetaliiComandas = foundAuto.DetaliiComandas;
        }
    }
}