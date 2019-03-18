using CarServiceCore.Context;

namespace CarServiceCore.Utils.Transformer
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