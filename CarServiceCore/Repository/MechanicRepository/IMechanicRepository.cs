using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.MechanicRepository
{
    public interface IMechanicRepository
    {
        List<Mecanic> GetMechanics();

        void AddMechanic(Mecanic mechanic);

        bool MechanicExists(Mecanic mechanic);

        void DeleteMechanic(Mecanic mechanic);

        void UpdateMechanic(Mecanic mechanic);

        Mecanic GetMechanic(Mecanic mechanic);

        List<Mecanic> PartialMechanicsSearch(Mecanic mechanic);
    }
}