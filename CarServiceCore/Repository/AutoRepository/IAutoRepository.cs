using System.Collections.Generic;
using CarServiceCore.Context;
using Microsoft.VisualBasic;

namespace CarServiceCore.Repository.AutoRepository
{
    public interface IAutoRepository
    {
        List<Automobil> GetAutosOfClient(Client client);

        bool AutoExists(Automobil auto);

        void AddAuto(Automobil auto);

        void UpdateAuto(Automobil auto);

        void DeleteAuto(int autoId);

        List<Comanda> GetOrdersForCar(Automobil auto);
        
        Automobil GetAuto(int autoId);
    }
}