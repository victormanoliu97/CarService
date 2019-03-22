using CarServiceCore.Context;
using CarServiceCore.Model;

namespace CarServiceCore.Utils.Mapper
{
    public abstract class ClientMapper
    {
        public static ClientModel fromEntityToModel(Client entityClient)
        {
            ClientModel clientModel = new ClientModel();
            clientModel.ClientId = entityClient.ClientId;
            clientModel.Nume = entityClient.Nume;
            clientModel.Prenume = entityClient.Prenume;
            clientModel.Email = entityClient.Email;
            clientModel.Telefon = entityClient.Telefon;
            clientModel.Judet = entityClient.Judet;
            clientModel.Localitate = entityClient.Localitate;
            clientModel.Adresa = entityClient.Adresa;
            return clientModel;
        }

        public static Client fromModelToEntity(ClientModel clientModel)
        {
            Client entityClient = new Client();
            if (clientModel != null)
            {
                entityClient.ClientId = clientModel.ClientId;
                entityClient.Nume = clientModel.Nume;
                entityClient.Prenume = clientModel.Prenume;
                entityClient.Email = clientModel.Email;
                entityClient.Telefon = clientModel.Telefon;
                entityClient.Judet = clientModel.Judet;
                entityClient.Localitate = clientModel.Localitate;
                entityClient.Adresa = clientModel.Adresa;
            }
            return entityClient;
        }
    }
}