using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;

namespace CarServiceContract
{
    [ServiceContract]
    public interface IMechanicService
    {
        [OperationContract]
        List<Mecanic> GetMechanics();

        [OperationContract]
        void AddMechanic(Mecanic mechanic);

        [OperationContract]
        bool MechanicExists(Mecanic mechanic);

        [OperationContract]
        void DeleteMechanic(int mechanicId);

        [OperationContract]
        void UpdateMechanic(Mecanic mechanic);

        [OperationContract]
        Mecanic GetMechanic(Mecanic mechanic);

        [OperationContract]
        List<Mecanic> PartialMechanicsSearch(Mecanic mechanic);

        [OperationContract]
        List<Mecanic> GetAvailableMechanicsToExecuteOperation();
    }
}
