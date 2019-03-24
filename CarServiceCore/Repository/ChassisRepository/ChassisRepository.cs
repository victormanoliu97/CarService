using System.Collections.Generic;
using System.Linq;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.ChassisRepository
{
    public class ChassisRepository : IChassisRepository
    {
        private readonly Entities _applicationContext;

        public ChassisRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public bool ChassisExists(Sasiu chassis)
        {
            if (chassis == null) return false;
            var foundChassis = _applicationContext.Sasius.FirstOrDefault(s => s.SasiuId == chassis.SasiuId);
            return foundChassis != null;
        }

        public List<Sasiu> GetAllChassis()
        {
            return _applicationContext.Sasius.ToList();
        }

        public Sasiu GetChassis(int chassisId)
        {
            if (chassisId == null) return null;
            var foundChassis = _applicationContext.Sasius.FirstOrDefault(s => s.SasiuId == chassisId);
            return foundChassis;
        }

        public void AddChassis(Sasiu chassis)
        {
            if(ChassisExists(chassis)) return;
            _applicationContext.Sasius.Add(chassis);
            _applicationContext.SaveChanges();
        }

        public void DeleteChassis(Sasiu chassis)
        {
            if (chassis == null) return;
            if (ChassisExists(chassis))
            {
                _applicationContext.Sasius.Remove(chassis);
                _applicationContext.SaveChanges();
            }
        }

        public void UpdateChassis(Sasiu chassis)
        {
            if (chassis == null) return;
            if (ChassisExists(chassis))
            {
                _applicationContext.Sasius.Remove(chassis);
                _applicationContext.SaveChanges();
            }
        }

        public List<Sasiu> PartialChassisSearch(Sasiu chassis)
        {
            if (chassis == null) return null;

            var queryByCode = _applicationContext.Sasius.Where(s => s.CodSasiu.Contains(chassis.CodSasiu));
            var queryByName = _applicationContext.Sasius.Where(s => s.Denumire.Contains(chassis.Denumire));

            if (queryByCode.Any())
            {
                return queryByCode.ToList();
            }

            return queryByName.Any() ? queryByCode.ToList() : null;
        }

        public List<Automobil> GetAutosForChassis(Sasiu chassis)
        {
            return chassis?.Automobils?.ToList();
        }
    }
}