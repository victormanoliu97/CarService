using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using CarServiceCore.Context;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.AutoRepository
{
    public class AutoRepository : IAutoRepository
    {   
        private readonly Entities _applicationContext;

        public AutoRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }
        
        public List<Automobil> GetAutosOfClient(Client client)
        {
            if (client == null) return null;
            var query = from auto in _applicationContext.Automobils
                where auto.ClientId == client.ClientId
                select auto;

            return query.ToList();
        }

        public bool AutoExists(Automobil auto)
        {
            if (auto == null) return false;
            var foundAuto = _applicationContext.Automobils.FirstOrDefault(a => a.AutoId == auto.AutoId);
            return foundAuto != null;
        }

        public void AddAuto(Automobil auto)
        {
            if (auto == null) return;
            if (AutoExists(auto)) return;
            _applicationContext.Automobils.Add(auto);
            _applicationContext.SaveChanges();
        }

        public void UpdateAuto(Automobil auto)
        {
            if (auto == null) return;
            var foundAuto = _applicationContext.Automobils.FirstOrDefault(a => a.AutoId == auto.AutoId);
            if (foundAuto == null) return;
            AutoTransformer.MergeAutoEntities(foundAuto, auto);
            _applicationContext.SaveChanges();
        }

        public void DeleteAuto(Automobil auto)
        {
            if (auto == null) return;
            var foundAuto = _applicationContext.Automobils.FirstOrDefault(a => a.AutoId == auto.AutoId);
            _applicationContext.Automobils.Remove(auto);
            _applicationContext.SaveChanges();
        }
    }
}