using System;

namespace CarServiceWCFClient.Model
{
    public class OperationModel
    {
        public int OperationId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> ExecutionTime { get; set; }

        public override string ToString()
        {
            return Name + " " + ExecutionTime;
        }
    }
}