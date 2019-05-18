using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCore.Context;
using CarServiceCore.Repository.OperationsRepository;

namespace CarServiceContract
{
    public class OperationServiceImpl : IOperationService
    {
        private static Entities _applicationContext = new Entities();
        private readonly OperationsRepository operationRepository = new OperationsRepository(_applicationContext);

        public List<Operatie> GetAllOperations()
        {
            return operationRepository.GetAllOperations();
        }

        public void AddOperation(Operatie operation)
        {
            operationRepository.AddOperation(operation);
        }

        public void DeleteOperation(int operationId)
        {
            operationRepository.DeleteOperation(operationId);
        }

        public void UpdateOperation(Operatie operation)
        {
            operationRepository.UpdateOperation(operation);
        }

        public bool OperationExists(Operatie operation)
        {
            return operationRepository.OperationExists(operation);
        }
    }
}
