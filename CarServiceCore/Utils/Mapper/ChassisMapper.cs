using CarServiceCore.Context;
using CarServiceCore.Model;

namespace CarServiceCore.Utils.Mapper
{
    public abstract class ChassisMapper
    {
        public static ChassisModel FromEntityToModel(Sasiu chassisEntity)
        {
            ChassisModel chassisModel = new ChassisModel();
            chassisModel.SasiuId = chassisEntity.SasiuId;
            chassisModel.Denumire = chassisEntity.Denumire;
            chassisModel.CodSasiu = chassisEntity.CodSasiu;
            return chassisModel;
        }

        public static Sasiu FromModelToEntity(ChassisModel chassisModel)
        {
            Sasiu chassisEntity = new Sasiu();
            chassisEntity.SasiuId = chassisModel.SasiuId;
            chassisEntity.Denumire = chassisModel.Denumire;
            chassisEntity.CodSasiu = chassisModel.CodSasiu;
            return chassisEntity;
        }
    }
}