using CarServiceCore.Context;
using CarServiceWCFClient.Model;

namespace CarServiceWCFClient.Utils.Mapper
{
    public class MechanicMapper
    {
        public static MechanicModel FromEntityToModel(Mecanic entityMechanic)
        {
            MechanicModel mechanicModel = new MechanicModel();
            mechanicModel.MechanicId = entityMechanic.MecanicId;
            mechanicModel.FirstName = entityMechanic.Nume;
            mechanicModel.LastName = entityMechanic.Prenume;
            return mechanicModel;
        }

        public static Mecanic FromModelToEntity(MechanicModel mechanicModel)
        {
            Mecanic mechanicEntity = new Mecanic();
            if (mechanicModel != null)
            {
                mechanicEntity.MecanicId = mechanicModel.MechanicId;
                mechanicEntity.Nume = mechanicModel.FirstName;
                mechanicEntity.Prenume = mechanicModel.LastName;
            }

            return mechanicEntity;
        }
    }
}