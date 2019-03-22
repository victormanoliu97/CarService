using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.OperationsRepository
{
    public interface IOperationsRepository
    {
        List<Operatie> GetAllOperations();

        void AddOperation(Operatie operation);

        void DeleteOperation(int operationId);

        void UpdateOperation(Operatie operation);

        bool OperationExists(Operatie operation);
    }
}