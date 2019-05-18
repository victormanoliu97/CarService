using CarServiceCore.Context;

namespace CarServiceWCFClient.Utils.Transformer
{
    public abstract class OrderDetailsTransformer
    {
        public static void MergeOrderDetailsEntity(DetaliiComanda orderDetailsDb, DetaliiComanda orderDetailsFound)
        {
            orderDetailsDb.ComandaId = orderDetailsFound.ComandaId;
            orderDetailsDb.AutoId = orderDetailsFound.AutoId;
            orderDetailsDb.MecanicId = orderDetailsFound.MecanicId;
            orderDetailsDb.OperatieId = orderDetailsFound.OperatieId;
            orderDetailsDb.ImagineId = orderDetailsFound.ImagineId;
        }
    }
}