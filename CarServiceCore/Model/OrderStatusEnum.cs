using System.Collections;
using System.Collections.Generic;

namespace CarServiceCore.Model
{
    public class OrderStatusEnum
    {
        public static IDictionary<string, string> WaitingOrder = new Dictionary<string, string>(){{"In asteptare", "Waiting"}};
        public static IDictionary<string, string> StartedOrder = new Dictionary<string, string>() {{"Inceput", "Begin"}};
        public static IDictionary<string, string> InProgressOrder = new Dictionary<string, string>(){ {"In evolutie", "Progress"}};
        public static IDictionary<string, string> ClientNotPresent = new Dictionary<string, string>(){{"Repogramare Client", "Not_Pres"}};
        public static IDictionary<string, string> OrderRefused = new Dictionary<string, string>() {{"Refuzata la executie", "Refused"}};
        public static IDictionary<string, string> OrderDenied = new Dictionary<string, string>(){{"Detalii nu pot fi indeplinite", "Tech_KO"}};
    }
}