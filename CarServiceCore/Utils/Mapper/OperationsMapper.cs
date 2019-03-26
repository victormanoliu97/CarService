using CarServiceCore.Context;
using CarServiceCore.Model;

namespace CarServiceCore.Utils.Mapper
{
    public class OperationsMapper
    {
        public static OperationModel FromEntityToModel(Operatie operationEntity)
        {
            OperationModel operationModel = new OperationModel();
            operationModel.OperationId = operationEntity.OperatieId;
            operationModel.Name = operationEntity.Denumire;
            operationModel.ExecutionTime = operationEntity.TimpExecutie;
            return operationModel;
        }

        public static Operatie FromModelToEntity(OperationModel operationModel)
        {
            Operatie operationEntity = new Operatie();
            if (operationModel != null)
            {
                operationEntity.OperatieId = operationModel.OperationId;
                operationEntity.Denumire = operationModel.Name;
                operationEntity.TimpExecutie = operationModel.ExecutionTime;
            }

            return operationEntity;
        }
    }
}