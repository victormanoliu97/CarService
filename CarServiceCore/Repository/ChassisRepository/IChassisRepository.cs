using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.ChassisRepository
{
    public interface IChassisRepository
    {
        bool ChassisExists(Sasiu chassis);

        List<Sasiu> GetAllChassis();

        Sasiu GetChassis(Sasiu chassis);

        void AddChassis(Sasiu chassis);

        void DeleteChassis(Sasiu chassis);

        void UpdateChassis(Sasiu chassis);

        List<Sasiu> PartialChassisSearch(Sasiu chassis);

        List<Automobil> GetAutosForChassis(Sasiu chassis);
    }
}