using System.Collections.Generic;
using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.OperationsRepository
{
    public class OperationsRepository : IOperationsRepository
    {
        private readonly Entities _applicationContext;

        public OperationsRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public List<Operatie> GetAllOperations()
        {
            return _applicationContext.Operaties.ToList();
        }

        public void AddOperation(Operatie operation)
        {
            if (operation == null) return;
            if (OperationExists(operation)) return;
            _applicationContext.Operaties.Add(operation);
        }

        public void DeleteOperation(int operationId)
        {
            if (operationId == null) return;
            var operation = _applicationContext.Operaties.FirstOrDefault(o => o.OperatieId == operationId);
            if (operation == null) return;
            
            var queryToGetOrderDetailsForOperation = from orderDetails in _applicationContext.DetaliiComandas
                where orderDetails.OperatieId == operationId
                select orderDetails;

            foreach (var op in queryToGetOrderDetailsForOperation.ToList())
            {
                op.OperatieId = 0;
            }

            _applicationContext.Operaties.Remove(operation);
            _applicationContext.SaveChanges();
        }

        public void UpdateOperation(Operatie operation)
        {
            if (operation == null) return;
            if (OperationExists(operation))
            {
                var clonedOperation = operation;
                OperationsTransformer.MergeOperationEntities(clonedOperation, operation);
            }

            _applicationContext.SaveChanges();
        }

        public bool OperationExists(Operatie operation)
        {
            if (operation == null) return false;
            var foundOperation = _applicationContext.Operaties.FirstOrDefault(o => o.OperatieId == operation.OperatieId);
            return foundOperation != null;
        }
    }
}