namespace CarServiceWCFClient.Model
{
    public class MechanicModel
    {
       public int MechanicId { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public override string ToString()
       {
           return FirstName + " " + LastName;
       }
    }
}