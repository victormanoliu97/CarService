using CarServiceCore.Context;
using CarServiceCore.Model;

namespace CarServiceCore.Utils.Mapper
{
    public abstract class AutoMapper
    {
        public static AutoModel FromEntityToModel(Automobil autoEntity)
        {
            AutoModel autoModel = new AutoModel();
            autoModel.AutoId = autoEntity.AutoId;
            autoModel.ClientId = autoEntity.ClientId;
            autoModel.NumarAuto = autoEntity.NumarAuto;
            autoModel.SasiuId = autoEntity.SasiuId;
            autoModel.SerieSasiu = autoEntity.SerieSasiu;
            return autoModel;
        }

        public static Automobil FromModelToEntity(AutoModel autoModel)
        {
            Automobil autoEntity = new Automobil();
            autoEntity.AutoId = autoModel.AutoId;
            autoEntity.ClientId = autoModel.ClientId;
            autoEntity.NumarAuto = autoModel.NumarAuto;
            autoEntity.SasiuId = autoModel.SasiuId;
            autoEntity.SerieSasiu = autoModel.SerieSasiu;
            return autoEntity;
        }
    }
}