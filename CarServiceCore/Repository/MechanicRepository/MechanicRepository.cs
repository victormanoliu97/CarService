using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using CarServiceCore.Context;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.MechanicRepository
{
    public class MechanicRepository : IMechanicRepository
    {
        private readonly Entities _applicationContext;

        public MechanicRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public List<Mecanic> GetMechanics()
        {
            return _applicationContext.Mecanics.ToList();
        }

        public void AddMechanic(Mecanic mechanic)
        {
            if (mechanic == null) return;
            if (MechanicExists(mechanic)) return;
            _applicationContext.Mecanics.Add(mechanic);
            _applicationContext.SaveChanges();
        }

        public bool MechanicExists(Mecanic mechanic)
        {
            if (mechanic == null) return false;
            var foundMechanic = _applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == mechanic.MecanicId);
            return foundMechanic != null;
        }

        public void DeleteMechanic(Mecanic mechanic)
        {
            if (mechanic == null) return;
            if (MechanicExists(mechanic))
            {
                _applicationContext.Mecanics.Remove(mechanic);
                _applicationContext.SaveChanges();
            }
        }

        public void UpdateMechanic(Mecanic mechanic)
        {
            if (mechanic == null) return;
            if (MechanicExists(mechanic))
            {
                var clonedMechanic = mechanic;
                MechanicTransformer.MergeMechanicEntities(clonedMechanic, mechanic);
            }

            _applicationContext.SaveChanges();
        }

        public Mecanic GetMechanic(Mecanic mechanic)
        {
            if (mechanic == null) return null;
            var foundMechanic = _applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == mechanic.MecanicId);
            return foundMechanic;
        }

        public List<Mecanic> PartialMechanicsSearch(Mecanic mechanic)
        {
            if (mechanic == null) return null;

            var queryByFirstName = _applicationContext.Mecanics.Where(m => m.Nume.Contains(mechanic.Nume));
            var queryByLastName = _applicationContext.Mecanics.Where(m => m.Prenume.Contains(mechanic.Prenume));

            if (queryByFirstName.Any())
            {
                return queryByFirstName.ToList();
            }

            return queryByLastName.Any() ? queryByLastName.ToList() : null;

        }
    }
}