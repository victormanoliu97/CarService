using CarServiceCore.Context;

namespace CarServiceWCFClient.Utils.Transformer
{
    public abstract class OperationsTransformer
    {
        public static void MergeOperationEntities(Operatie dbOperation, Operatie foundOperation)
        {
            dbOperation.Denumire = foundOperation.Denumire;
            dbOperation.TimpExecutie = foundOperation.TimpExecutie;
        }
    }
}