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
    public interface IOperationService
    {
        [OperationContract]
        List<Operatie> GetAllOperations();

        [OperationContract]
        void AddOperation(Operatie operation);

        [OperationContract]
        void DeleteOperation(int operationId);

        [OperationContract]
        void UpdateOperation(Operatie operation);

        [OperationContract]
        bool OperationExists(Operatie operation);
    }
}
