using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;
using CarServiceCore.Repository.ChassisRepository;

namespace CarServiceContract
{
    public class ChassisServiceImpl : IChassisService
    {
        public ChassisServiceImpl()
        {

        }

        private static Entities _applicationContext = new Entities();
        private readonly ChassisRepository chassisRepository = new ChassisRepository(_applicationContext);

        public bool ChassisExists(Sasiu chassis)
        {
            return chassisRepository.ChassisExists(chassis);
        }

        public List<Sasiu> GetAllChassis()
        {
            return chassisRepository.GetAllChassis();
        }

        public Sasiu GetChassis(int chassisId)
        {
            return chassisRepository.GetChassis(chassisId);
        }

        public void AddChassis(Sasiu chassis)
        {
            chassisRepository.AddChassis(chassis);
        }

        public void DeleteChassis(Sasiu chassis)
        {
            chassisRepository.DeleteChassis(chassis);
        }

        public void UpdateChassis(Sasiu chassis)
        {
            chassisRepository.UpdateChassis(chassis);
        }

        public List<Sasiu> PartialChassisSearch(Sasiu chassis)
        {
            return chassisRepository.PartialChassisSearch(chassis);
        }

        public List<Automobil> GetAutosForChassis(Sasiu chassis)
        {
            return chassisRepository.GetAutosForChassis(chassis);
        }
    }
}
