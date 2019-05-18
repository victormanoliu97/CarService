using CarServiceCore.Context;
using CarServiceWCFClient.Model;

namespace CarServiceWCFClient.Utils.Mapper
{
    public abstract class OrderMapper
    {
        public static OrderModel FromEntityToModel(Comanda entityOrder)
        {
            OrderModel orderModel = new OrderModel();
            orderModel.AutoId = entityOrder.AutoId;
            orderModel.ClientId = entityOrder.ClientId;
            orderModel.ComandaId = entityOrder.ComandaId;
//            orderModel.NumarAuto = entityOrder.Automobil.NumarAuto;
            orderModel.StareComanda = entityOrder.StareComanda;
            orderModel.AppointmentDate = entityOrder.DataProgramare;
            orderModel.FinalizationDate = entityOrder.DataFinalizare;
            orderModel.DataSystem = entityOrder.DataSystem;
            orderModel.KmBord = entityOrder.KmBord;
            orderModel.Descriere = entityOrder.Descriere;
            orderModel.ValoarePiese = entityOrder.ValoarePiese;
            return orderModel;
        }

        public static Comanda FromModelToEntity(OrderModel orderModel)
        {
            Comanda orderEntity = new Comanda();
            orderEntity.ComandaId = orderModel.ComandaId;
            orderEntity.AutoId = orderModel.AutoId;
            orderEntity.ClientId = orderModel.ClientId;
            orderEntity.StareComanda = orderModel.StareComanda;
            orderEntity.DataSystem = orderModel.DataSystem;
            orderEntity.DataProgramare = orderModel.AppointmentDate;
            orderEntity.DataFinalizare = orderModel.FinalizationDate;
            orderEntity.KmBord = orderModel.KmBord;
            orderEntity.Descriere = orderModel.Descriere;
            orderEntity.ValoarePiese = orderModel.ValoarePiese;
            return orderEntity;
        }
    }
}