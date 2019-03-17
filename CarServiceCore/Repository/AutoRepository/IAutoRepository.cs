using System.Collections.Generic;
using CarServiceCore.Context;
using Microsoft.VisualBasic;

namespace CarServiceCore.Repository.AutoRepository
{
    public interface IAutoRepository
    {
        List<Automobil> GetAutosOfClient(Client client);

        void AddAuto(Automobil auto);

        void UpdateAuto(Automobil auto);

        void DeleteAuto(Automobil auto);
    }
}