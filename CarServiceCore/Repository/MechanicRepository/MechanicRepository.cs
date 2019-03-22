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

        public void DeleteMechanic(int mechanicId)
        {
            if (mechanicId == null) return;
            var mechanic = _applicationContext.Mecanics.FirstOrDefault(m => m.MecanicId == mechanicId);
            if (MechanicExists(mechanic))
            {
                var queryToGetOrderDetailsForMechanic = from orderDetails in _applicationContext.DetaliiComandas
                    where orderDetails.MecanicId == mechanicId
                    select orderDetails;
                
                // When we delete a mechanic we assign another available mechanic to take care of the Order
                foreach (var orderDetails in queryToGetOrderDetailsForMechanic.ToList())
                {
                    foreach(var availableMechanic in GetAvailableMechanicsToExecuteOperation())
                    {
                        orderDetails.MecanicId = availableMechanic.MecanicId;
                    }
                }

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
        
        public List<Mecanic> GetAvailableMechanicsToExecuteOperation()
        {
            var getAllMechanicsAssigned = from o in _applicationContext.DetaliiComandas
                select o.MecanicId;

            var getAllMechanics = from o in _applicationContext.Mecanics
                select o.MecanicId;

            var availableIdList = getAllMechanics.ToList().Except(getAllMechanicsAssigned);

            var availableMechanics = new List<Mecanic>();
            foreach (var id in availableIdList)
            {
                availableMechanics.Add(_applicationContext.Mecanics.First(i => i.MecanicId == id));
            }

            return availableMechanics;
        }
    }
}