using CarServiceCore.Context;

namespace CarServiceCore.Utils.Transformer
{
    public abstract class OrderTransformer
    {
        public static void MergeOrderEntities(Comanda dbOrder, Comanda foundOrder)
        {
            dbOrder.AutoId = foundOrder.AutoId;
            dbOrder.ClientId = foundOrder.ClientId;
            dbOrder.DetaliiComandaId = foundOrder.DetaliiComandaId;
            dbOrder.StareComanda = foundOrder.StareComanda;
            dbOrder.DataSystem = foundOrder.DataSystem;
            dbOrder.DataProgramare = foundOrder.DataProgramare;
            dbOrder.DataFinalizare = foundOrder.DataFinalizare;
            dbOrder.KmBord = foundOrder.KmBord;
            dbOrder.Descriere = foundOrder.Descriere;
            dbOrder.ValoarePiese = foundOrder.ValoarePiese;
        }
    }
}