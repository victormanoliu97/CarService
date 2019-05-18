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
    public interface IChassisService
    {
        [OperationContract]
        bool ChassisExists(Sasiu chassis);

        [OperationContract]
        List<Sasiu> GetAllChassis();

        [OperationContract]
        Sasiu GetChassis(int chassisId);

        [OperationContract]
        void AddChassis(Sasiu chassis);

        [OperationContract]
        void DeleteChassis(Sasiu chassis);

        [OperationContract]
        void UpdateChassis(Sasiu chassis);

        [OperationContract]
        List<Sasiu> PartialChassisSearch(Sasiu chassis);

        [OperationContract]
        List<Automobil> GetAutosForChassis(Sasiu chassis);
    }
}
