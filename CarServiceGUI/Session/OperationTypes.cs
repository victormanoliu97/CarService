using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceGUI.Session
{
    public abstract class OperationTypes
    {
        public readonly static string MODIFY_CLIENT = "MODIFY_CLIENT";
        public readonly static string ADD_CLIENT = "ADD_CLIENT";
        public readonly static string ADD_AUTO = "ADD_AUTO";
        public readonly static string MODIFY_AUTO = "MODIFY_AUTO";
    }
}
