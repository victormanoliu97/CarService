using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;
using CarServiceCore.Repository.AutoRepository;

namespace CarServiceContract
{
    public class AutoServiceImpl : IAutoService
    {
        private static Entities _applicationContext = new Entities();
        private readonly AutoRepository autoRepository = new AutoRepository(_applicationContext);

        public AutoServiceImpl()
        {

        }

        public List<Automobil> GetAutosOfClient(Client client)
        {
            return autoRepository.GetAutosOfClient(client);
        }

        public bool AutoExists(Automobil auto)
        {
            return autoRepository.AutoExists(auto);
        }

        public void AddAuto(Automobil auto)
        {
            autoRepository.AddAuto(auto);
        }

        public void UpdateAuto(Automobil auto)
        {
            autoRepository.AddAuto(auto);
        }

        public void DeleteAuto(int autoId)
        {
            autoRepository.DeleteAuto(autoId);
        }

        public List<Comanda> GetOrdersForCar(Automobil auto)
        {
           return autoRepository.GetOrdersForCar(auto);
        }

        public Automobil GetAuto(int autoId)
        {
            return autoRepository.GetAuto(autoId);
        }
    }
}
