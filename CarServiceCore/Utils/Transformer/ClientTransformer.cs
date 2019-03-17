using CarServiceCore.Context;

namespace CarServiceCore.Utils.Transformer
{
    public abstract class ClientTransformer
    {
        public static void MergeClientEntities(Client dbClient, Client foundClient)
        {
            dbClient.Nume = foundClient.Nume;
            dbClient.Prenume = foundClient.Prenume;
            dbClient.Adresa = foundClient.Adresa;
            dbClient.Judet = foundClient.Judet;
            dbClient.Localitate = foundClient.Localitate;
            dbClient.Email = foundClient.Email;
            dbClient.Telefon = foundClient.Telefon;
        }
    }
}