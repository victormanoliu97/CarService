using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;
using CarServiceCore.Repository.MechanicRepository;

namespace CarServiceContract
{
    public class MechanicServiceImpl : IMechanicService
    {
        private static Entities _applicationContext = new Entities();
        private readonly MechanicRepository mechanicRepository = new MechanicRepository(_applicationContext);

        public MechanicServiceImpl()
        {

        }

        public List<Mecanic> GetMechanics()
        {
            return mechanicRepository.GetMechanics();
        }

        public void AddMechanic(Mecanic mechanic)
        {
            mechanicRepository.AddMechanic(mechanic);
        }

        public bool MechanicExists(Mecanic mechanic)
        {
            return mechanicRepository.MechanicExists(mechanic);
        }

        public void DeleteMechanic(int mechanicId)
        {
            mechanicRepository.DeleteMechanic(mechanicId);
        }

        public void UpdateMechanic(Mecanic mechanic)
        {
            mechanicRepository.UpdateMechanic(mechanic);
        }

        public Mecanic GetMechanic(Mecanic mechanic)
        {
            return mechanicRepository.GetMechanic(mechanic);
        }

        public List<Mecanic> PartialMechanicsSearch(Mecanic mechanic)
        {
            return mechanicRepository.PartialMechanicsSearch(mechanic);
        }

        public List<Mecanic> GetAvailableMechanicsToExecuteOperation()
        {
            return mechanicRepository.GetAvailableMechanicsToExecuteOperation();
        }
    }
}
