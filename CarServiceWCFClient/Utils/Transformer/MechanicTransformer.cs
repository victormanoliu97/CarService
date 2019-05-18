using CarServiceCore.Context;

namespace CarServiceWCFClient.Utils.Transformer
{
    public abstract class MechanicTransformer
    {
        public static void MergeMechanicEntities(Mecanic dbMechanic, Mecanic foundMechanic)
        {
            dbMechanic.Nume = foundMechanic.Nume;
            dbMechanic.Prenume = foundMechanic.Prenume;
        }
    }
}